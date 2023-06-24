

using Home_Away.DAL;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Home_Away.BL.Dtos;

public class ReviewsReadDto
{
    public  int Id { get; set; }
    public  string ReviewText { get; set; } = string.Empty;

    public  decimal Rating { get; set; }
    [Column(TypeName = "date")]
    public DateTime ReviewDate { get; set; } 

    public  string State { get; set; } = "Pending";

    public string UserId { get; set; }= string.Empty;

}
