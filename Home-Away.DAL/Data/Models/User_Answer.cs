using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Home_Away.DAL;

[PrimaryKey(nameof(UserId),nameof(QuestionsId))]
public class User_Answer
{
    public string UserAnswers { get; set; } = string.Empty;
    //Navigation property //2 forienKEY

    //[ForeignKey("Users")]
    public string UserId { get; set; }
    public User User { get; set; }

    //[ForeignKey("Questions")]
    public int QuestionsId { get; set; }
    public Questions Questions { get; set; }


}
