using Home_Away.BL.DTOS.QuestionDTOS;
using Home_Away.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Away.BL.Managers.QuestionManagers
{
    public class QuestionManager : IQuestionManager
    {
        private readonly IQuestionsRepo _questionsRepo;
        public QuestionManager(IQuestionsRepo questionsRepo) {
            _questionsRepo = questionsRepo;
        }
        public int AddQuestion(QuestionAddDTO question)
        {
            Questions questionToDb = new Questions
            {
                QuestionText = question.QuestionText,
            };
             _questionsRepo.AddQuestion(questionToDb);
            _questionsRepo.SaveChanges();
            return questionToDb.QuestionsId;
        }

        public bool DeleteQuestion(int id)
        {
            Questions? questionFromDb = _questionsRepo.GetQuestionById(id);
            if (questionFromDb == null)
            {
                return false;
            }
            _questionsRepo.DeleteQuestion(questionFromDb);
            _questionsRepo.SaveChanges();
            return true;

        }

        public IEnumerable<QuestionReadDTO> GetAllQuestions()
        {
            IEnumerable<Questions> questionsFromDB= _questionsRepo.GetAllQuestions();
            return questionsFromDB.Select(q => new QuestionReadDTO
            {
                QuestionId = q.QuestionsId,
                QuestionText=q.QuestionText,
                //choices=q.choices
            });
        }

        public QuestionReadDTO? GetQuestionById(int id)
        {
            Questions? questionFromDb=_questionsRepo.GetQuestionById(id);
            if(questionFromDb == null) {
                return null;
            }
            else
            {
                return new QuestionReadDTO
                {
                    QuestionId = questionFromDb.QuestionsId,
                    QuestionText = questionFromDb.QuestionText,
                    //choices = questionFromDb.choices
                };
            }
            
        }

        public bool UpdateQuestion(QuestionUpdateDTO question)
        {
            Questions? questionFromDb = _questionsRepo.GetQuestionById(question.QuestionsId);
            if(questionFromDb == null)
            {
                return false;
            }   
            
            questionFromDb.QuestionText = question.QuestionText;
            _questionsRepo.SaveChanges();
            return true;
            
        }
    }
}
