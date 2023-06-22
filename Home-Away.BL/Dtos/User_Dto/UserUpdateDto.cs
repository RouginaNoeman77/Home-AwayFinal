

using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Home_Away.BL.Dtos;

public class UserUpdateDto
{
    public string UserId { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Gender { get; set; } = string.Empty;
    [Column(TypeName = "date")]
    public DateTime DateOfBirth { get; set; }
    [Column(TypeName = "decimal(10,2)")]
    public decimal TotalMoneySpent { get; set; }

    public string ProfileImage { get; set; } = string.Empty;
    
}
