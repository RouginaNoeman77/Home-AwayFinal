using Home_Awaystem;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Away.BL
{
    public interface IChoiceManager
    {
        IEnumerable<ChoiceReadDTO> GetAllChoicesByQuestionId(int id);
        ChoiceReadDTO? GetChoiceById(int id);
        bool UpdateChoice(ChoiceUpdateDTO choice);
        int AddChoice(ChoiceAddDTO choice);
        bool DeleteChoice(int id);
    }
}
