using System.ComponentModel.DataAnnotations.Schema;

namespace Home_Away.BL.Dtos;
public class ReservationUpdateDto
{
    public int Id { get; set; }
    [Column(TypeName = "date")]
    public DateTime DateFrom { get; set; }
    [Column(TypeName = "date")]
    public DateTime DateTo { get; set; }
    public string StateFromOwner { get; set; } = "Pending";
    public string StateFromAdmin { get; set; } = "Pending";
    public string ReservationState { get; set; } = "Pending";
    public int PropertyId { get; set; }
}
