using System.ComponentModel.DataAnnotations.Schema;

namespace Home_Away.DAL;

public class Choices
{
    public int Id { get; set; }
    public string Text { get; set; } = string.Empty;

    //Navigation property

    [ForeignKey("Questions")]
    public int QuestionsId { get; set; }
    public Questions Questions { get; set; }


}
