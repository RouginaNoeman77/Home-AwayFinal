using Home_Away.BL.Dtos.Images_Dto;
using Home_Away.BL.Dtos.User_Answer_Dto;
using Home_Away.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Away.BL.Managers.User_Answer_Manager
{
    public class User_Answer_Manager : IUser_Answer_Manager
    {
        private readonly IUser_AnswersRepo _user_AnswersRepo;
        public User_Answer_Manager(IUser_AnswersRepo user_AnswersRepo)
        {
            _user_AnswersRepo = user_AnswersRepo;
        }

        public IEnumerable<User_Answer_ReadDto> GetAllUserAnswerByQuestionId(int QuestionId)
        {
            var UserAnswerByQuestionIdFromDb = _user_AnswersRepo.GetAllUserAnswerByQuestionId(QuestionId);

            return UserAnswerByQuestionIdFromDb.Select(i => new User_Answer_ReadDto
            {
               QuestionsId = i.QuestionsId,
               UserId = i.UserId,
               UserAnswers = i.UserAnswers,
            }).ToList();
        }

        public IEnumerable<User_Answer_ReadDto> GetAllUserAnswerByUserId(string UserId)
        {
            var UserAnswerByUserIdFromDb = _user_AnswersRepo.GetAllUserAnswerByUserId(UserId);

            return UserAnswerByUserIdFromDb.Select(i => new User_Answer_ReadDto
            {
                QuestionsId = i.QuestionsId,
                UserId = i.UserId,
                UserAnswers = i.UserAnswers,
            }).ToList();
        }

        public IEnumerable<User_Answer_ReadDto> GetUserAnswerByQuestionIdandUserId(int QuestionId, string userId)
        {
            var UserAnswerByQuestionIdandUserIdFromDb = _user_AnswersRepo.GetUserAnswerByQuestionIdandUserId(QuestionId,userId);

            return UserAnswerByQuestionIdandUserIdFromDb.Select(i => new User_Answer_ReadDto
            {
                QuestionsId = i.QuestionsId,
                UserId = i.UserId,
                UserAnswers = i.UserAnswers,
            }).ToList();
        }

        public void AddUserAnswer(User_Answer_AddDto user_Answer)
        {
            var userAnswers = new User_Answer
            {
                UserAnswers = user_Answer.UserAnswers,
                QuestionsId = user_Answer.QuestionsId,
                UserId = user_Answer.UserId,
            };
            _user_AnswersRepo.AddUserAnswer(userAnswers);
            _user_AnswersRepo.SaveChanges();
        }
    }
}
