using Home_Away.BL.DTOS;
using Home_Away.BL.DTOS.ChoicesDTOS;
using Home_Away.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Away.BL.Managers.ChoiceManagers
{
    public class ChoiceManager : IChoiceManager
    {
        private readonly IChoicesRepo _choicesRepo;
        public ChoiceManager(IChoicesRepo choicesRepo) {
            _choicesRepo = choicesRepo;
        }

        public int AddChoice(ChoiceAddDTO choice)
        {
            Choices choiceToDb = new Choices
            {
                Text = choice.Text,
                QuestionsId=choice.QuestionsId,
            };
            _choicesRepo.AddChoices(choiceToDb);
            _choicesRepo.SaveChanges();
            return choiceToDb.Id;
        }

        public bool DeleteChoice(int id)
        {
            Choices? choiceFromDb= _choicesRepo.GetChoicesById(id);
            if (choiceFromDb == null )
            {
                return false;
            }
            _choicesRepo.DeleteChoices(choiceFromDb);
            _choicesRepo.SaveChanges();
            return true;
        }

        public IEnumerable<ChoiceReadDTO> GetAllChoicesByQuestionId(int id)
        {
            IEnumerable<Choices> choicesFromDb = _choicesRepo.GetChoicesByQuestionId(id);
            return choicesFromDb.Select(c => new ChoiceReadDTO
            {
                Text = c.Text,
                //QuestionsId=c.QuestionsId,

            });
        }

        public ChoiceReadDTO? GetChoiceById(int id)
        {
            Choices? choiceFromDb = _choicesRepo.GetChoicesById(id);
            if(choiceFromDb == null )
            {
                return null;
            }
            else
            {
                return new ChoiceReadDTO { Text = choiceFromDb.Text };
            }

        }

        public bool UpdateChoice(ChoiceUpdateDTO choice)
        {
            Choices? choiceFromDb = _choicesRepo.GetChoicesById(id);
            if (choiceFromDb == null)
            {
                return false;
            }
            choiceFromDb.Text = choice.Text;
            choiceFromDb.QuestionsId= choice.QuestionsId;
            _choicesRepo.SaveChanges();
            return true;    
        }
    }
}
