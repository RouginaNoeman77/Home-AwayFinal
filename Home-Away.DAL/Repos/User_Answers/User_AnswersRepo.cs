using Microsoft.AspNetCore.Identity;
using System.Numerics;

namespace Home_Away.DAL;
public class User_AnswersRepo : IUser_AnswersRepo
{
    private readonly UserContext userContext;
    public User_AnswersRepo(UserContext userContext )
    {
        this.userContext = userContext;
    }
    public IEnumerable<User_Answer> GetAllUserAnswerByUserId(string userId)
    {
        return userContext.Set<User_Answer>().Where(d => d.UserId == userId);
    }

    public IEnumerable<User_Answer> GetAllUserAnswerByQuestionId(int questionId)
    {
        return userContext.Set<User_Answer>().Where(d => d.QuestionsId == questionId);
    }
    public IEnumerable<User_Answer> GetUserAnswerByQuestionIdandUserId(int questionId, string userId)
    {
        return userContext.Set<User_Answer>()
            .Where(d => d.QuestionsId == questionId && d.UserId == userId);
    }
    public void AddUserAnswer(User_Answer user_Answer)
    {
        userContext.Set<User_Answer>().Add(user_Answer);
    }

    
}

