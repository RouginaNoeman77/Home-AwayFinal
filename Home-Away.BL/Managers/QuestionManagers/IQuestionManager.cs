using Home_Away.BL.DTOS.QuestionDTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Away.BL.Managers.QuestionManagers
{
    public interface IQuestionManager
    {
      IEnumerable<QuestionReadDTO> GetAllQuestions();
      QuestionReadDTO? GetQuestionById(int id);
      int AddQuestion (QuestionAddDTO question);
      bool UpdateQuestion (QuestionUpdateDTO question);
      bool DeleteQuestion (int id);

    }
}
