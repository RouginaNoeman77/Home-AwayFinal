namespace Home_Away.BL.Dtos;
public class ReservationUpdateDto
{
    public int Id { get; set; }
    public DateTime DateFrom { get; set; }
    public DateTime DateTo { get; set; }
    public string StateFromOwner { get; set; } = "Pending";
    public string StateFromAdmin { get; set; } = "Pending";
    public string ReservationState { get; set; } = "Pending";
    public int PropertyId { get; set; }
}
