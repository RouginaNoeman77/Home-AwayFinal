namespace Home_Away.BL.Dtos;
public class ReservationsAddDto
{
    public DateTime DateFrom { get; set; }
    public DateTime DateTo { get; set; }
	public int PropertyId { get; set; }
}
