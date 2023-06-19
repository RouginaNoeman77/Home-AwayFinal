using System.ComponentModel.DataAnnotations.Schema;

namespace Home_Away.DAL;

public class Reservations
{
    public int Id { get; set; }
    [Column(TypeName = "date")] 
    public DateTime RequestDate { get; set; } = DateTime.Now;
    [Column(TypeName = "date")] 
    public DateTime DateFrom { get; set; } = DateTime.Now;
    [Column(TypeName = "date")] 
    public DateTime DateTo { get; set; } = DateTime.Now;
    public string StateFromOwner { get; set; } = "Pending";
    public string StateFromAdmin { get; set; } = "Pending";
    public string ReservationState { get; set; } = "Pending";

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
