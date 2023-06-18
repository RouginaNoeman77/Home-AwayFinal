using System.ComponentModel.DataAnnotations.Schema;

namespace Home_Away.BL.Dtos;
public class ReservationsAddDto
{
    [Column(TypeName = "date")]
    public DateTime DateFrom { get; set; }= DateTime.Now;
    [Column(TypeName = "date")]
    public DateTime DateTo { get; set; }
	public int PropertyId { get; set; }
}
