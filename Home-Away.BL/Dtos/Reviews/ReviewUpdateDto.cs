

namespace Home_Away.BL.Dtos;

public class ReviewUpdateDto
{
    public int Id { get; set; }
    public string ReviewText { get; set; }=string.Empty;
    public decimal Rating { get; set; }
    public string State { get; set; } = "pending";
    
}
