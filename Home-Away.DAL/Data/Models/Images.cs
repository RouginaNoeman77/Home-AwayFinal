using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Home_Away.DAL;

public class Images
{
  public int Id { get; set; }
  public string Url { get; set; } = string.Empty;

  [ForeignKey("Property")]
  public int PropertyId { get; set; }

[JsonIgnore]
public Property Property { get; set; }

}
