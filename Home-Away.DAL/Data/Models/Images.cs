using System.ComponentModel.DataAnnotations.Schema;

namespace Home_Away.DAL;

public class Images
{
  public int Id { get; set; }
  public string Url { get; set; } = string.Empty;

  [ForeignKey("Property")]
  public int PropertyId { get; set; }
  public Property Property { get; set; }

}
