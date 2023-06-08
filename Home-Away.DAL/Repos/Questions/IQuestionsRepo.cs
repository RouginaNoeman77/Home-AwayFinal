
namespace Home_Away.DAL;
    public interface IQuestionsRepo
    {
        IEnumerable<Questions> GetAllQuestions();
        Questions? GetQuestionById(int id);

        void AddQuestion(Questions question);
        void DeleteQuestion(Questions question);
        void UpdateQuestion(Questions question);
        int SaveChanges();




    }
