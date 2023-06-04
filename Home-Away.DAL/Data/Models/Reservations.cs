using System.ComponentModel.DataAnnotations.Schema;

namespace Home_Away.DAL;

public class Reservations
{
    public int Id { get; set; }
    public DateTime RequestDate { get; set; }
    public DateTime DateFrom { get; set; }
    public DateTime DateTo { get; set; }

    public string StateFromOwner { get; set; } = "Pending";
    public string StateFromAdmin { get; set; } = "Pending";

    //Navigation Property 

    [ForeignKey("Propery")]
    public int PropertyId { get; set; }
    public Property Property { get; set; }

    [ForeignKey("Admin")]
    public string? AdminId { get; set; } //for Approve
    public Admin Admin { get; set; }

    [ForeignKey("User")]
    public string? UserId { get; set; } //for Rent
    public User User { get; set; }
}
