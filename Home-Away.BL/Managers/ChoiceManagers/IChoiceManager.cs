
using Home_Away.BL.DTOS;
using Home_Away.BL.DTOS.ChoicesDTOS;

namespace Home_Away.BL.Managers.ChoiceManagers
{
    public interface IChoiceManager
    {
        IEnumerable<ChoiceReadDTO> GetAllChoicesByQuestionId(int id);
        ChoiceReadDTO? GetChoiceById(int id);
        bool UpdateChoice (ChoiceUpdateDTO choice);
        int AddChoice (ChoiceAddDTO choice);
        bool DeleteChoice(int id);

    }
}
