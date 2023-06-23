using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Home_Away.DAL;

public class Reviews
{
    public int Id { get; set; }
    public string ReviewText { get; set; }=string.Empty;

    [Column(TypeName = "decimal(10,2)")]
    public decimal Rating { get; set; }
    [Column(TypeName = "date")] 
    public DateTime ReviewDate { get; set; } = DateTime.Now;

    public string State { get; set; } = "Pending";

    //Navigation Property 

    [ForeignKey("Propery")]
    public int PropertyId { get; set; }
    public Property Property { get; set; }

    [ForeignKey("Admin")]
    public string? AdminId { get; set; } //for Approve
    public Admin Admin { get; set; }

    [ForeignKey("User")]
    public string? UserId { get; set; } //for Rent
    [JsonIgnore]
    public User User { get; set; }


}
