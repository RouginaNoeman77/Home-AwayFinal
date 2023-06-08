namespace Home_Away.BL.Dtos;
public class ReservationsAddDto
{
    public DateTime RequestDate { get; set; } //date time .now 
    public DateTime DateFrom { get; set; }
    public DateTime DateTo { get; set; }
    public string StateFromOwner { get; set; } = "Pending";  //to be removed 
    public string StateFromAdmin { get; set; } = "Pending";//to be removed 
	public string ReservationState { get; set; } = "Pending";//to be removed 
	public int PropertyId { get; set; }
    public string? AdminId { get; set; }//to be removed 
	public string? UserId { get; set; }//to be removed 


}
