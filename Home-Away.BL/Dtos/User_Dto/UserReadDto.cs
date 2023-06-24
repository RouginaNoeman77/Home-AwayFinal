

using Home_Away.DAL;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Home_Away.BL.Dtos;

public class UserReadDto
{
    public string UserId { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string UserEmail { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Gender { get; set; } = string.Empty;
    [Column(TypeName = "date")]
    public DateTime DateOfBirth { get; set; } 
    public int Owner { get; set; } = 0;
    [Column(TypeName = "date")] 
    public DateTime EntryDate { get; set; }
    [Column(TypeName = "date")] 
    public DateTime HiringDate { get; set; } 
    [Column(TypeName = "decimal(10,2)")]
    public decimal TotalMoneySpent { get; set; }
    public string ProfileImage { get; set; } = string.Empty;
    public int AcountState { get; set; } = 1;
    public ICollection<DAL.Property> OwnedProperties=new HashSet<DAL.Property>();
    public ICollection<Reviews> Reviews = new HashSet<Reviews>();
    public ICollection<User_Answer> Answers = new HashSet<User_Answer>();
    public ICollection<Reservations> Reservations = new HashSet<Reservations>();
}
