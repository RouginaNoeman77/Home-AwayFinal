namespace Home_Away.DAL;
public class Questions
{
    public int QuestionsId { get; set; }
    public string QuestionText { get; set; } = string.Empty;

    //Navigation Propery 
   
    public ICollection<User_Answer> UsersAnswer { get; set; } = new HashSet<User_Answer>();

    public ICollection<Choices> choices { get; set; } = new HashSet<Choices>();
}

