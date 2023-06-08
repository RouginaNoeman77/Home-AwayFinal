

namespace Home_Away.DAL;
    public interface IChoicesRepo

    {
        IEnumerable<Choices> GetChoicesByQuestionId(int questionId);
        Choices? GetChoicesById(int ChoiceId);
        void AddChoices(Choices choice);
        void DeleteChoices(Choices choice);
        void UpdateChoices(Choices choice);
        int SaveChanges();
    }


