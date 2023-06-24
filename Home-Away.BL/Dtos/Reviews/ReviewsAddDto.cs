

using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Home_Away.BL.Dtos;

public class ReviewsAddDto
{
    // public int Id { get; set; }
    public string ReviewText { get; set; } = string.Empty;

    public decimal Rating { get; set; }
    [Column(TypeName = "date")]
    public DateTime ReviewDate { get; set; } = DateTime.Now;

    public string State { get; set; } = "Pending";
    public int PropertyId { get; set; }

    public string? UserId { get; set; }
    public string? AdminId { get; set; }
}
