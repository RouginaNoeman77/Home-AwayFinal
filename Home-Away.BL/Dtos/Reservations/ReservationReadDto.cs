
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Home_Away.BL.Dtos;

public class ReservationReadDto
{
    public int Id { get; set; }
    [Column(TypeName = "date")]
    public DateTime RequestDate { get; set; }
    [Column(TypeName = "date")]
    public DateTime DateFrom { get; set; }
    [Column(TypeName = "date")]
    public DateTime DateTo { get; set; }
    public string StateFromOwner { get; set; } = "Pending";
    public string StateFromAdmin { get; set; } = "Pending";
    public string ReservationState { get; set; } = "Pending";
    public int PropertyId { get; set; }
    public string AdminId { get; set; }
    public string UserId { get; set; }
}
