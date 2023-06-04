namespace Home_Away.BL.Dtos;
public class ReservationsAddDto
{
    public DateTime RequestDate { get; set; }
    public DateTime DateFrom { get; set; }
    public DateTime DateTo { get; set; }
    public string StateFromOwner { get; set; } = "Pending";
    public string StateFromAdmin { get; set; } = "Pending";
    public int PropertyId { get; set; }
    public string? AdminId { get; set; }
    public string? UserId { get; set; }
}
