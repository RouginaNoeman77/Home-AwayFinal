
namespace Home_Away.DAL;
public class QuestionsRepo : IQuestionsRepo
{
    private readonly UserContext _userContext;
    public QuestionsRepo(UserContext userContext)
    {
        _userContext = userContext;
    }
    public void AddQuestion(Questions question)
    {
        _userContext.Set<Questions>().Add(question);
    }

    public void DeleteQuestion(Questions question)
    {
        _userContext.Set<Questions>().Remove(question);
    }

    public IEnumerable<Questions> GetAllQuestions()
    {
       return _userContext.Set<Questions>().ToList();
    }

    public Questions? GetQuestionById(int id)
    {
        return _userContext.Set<Questions>().Find(id);
    }

    public int SaveChanges()
    {
       return _userContext.SaveChanges();
    }

    public void UpdateQuestion(Questions question)
    {
        //
    }

 
}
