namespace Home_Away.DAL;
    public interface IUser_AnswersRepo
{
    //Get all this user Answers 
    IEnumerable<User_Answer> GetAllUserAnswerByUserId(string UserId);

    //Get all User Answers on this Question
    IEnumerable<User_Answer> GetAllUserAnswerByQuestionId(int QuestionId);

    //Get this User Answer On this Question
    IEnumerable<User_Answer> GetUserAnswerByQuestionIdandUserId(int QuestionId, string userId);
    void AddUserAnswer(User_Answer user_Answer);
    int SaveChanges();
}
    
   
