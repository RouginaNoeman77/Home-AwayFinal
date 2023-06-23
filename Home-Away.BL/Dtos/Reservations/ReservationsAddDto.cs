using System.ComponentModel.DataAnnotations.Schema;

namespace Home_Away.BL.Dtos;
public class ReservationsAddDto
{
    [Column(TypeName = "date")]
    public DateTime RequestDate { get; set; }
    [Column(TypeName = "date")]
    public DateTime DateFrom { get; set; }
    [Column(TypeName = "date")]
    public DateTime DateTo { get; set; }
	public int PropertyId { get; set; }
    public string UserId { get; set; }
    public string AdminId { get; set; }
    public string ReservationState { get; set; } = "Pending";
}
