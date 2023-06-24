using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Home_Away.DAL;

public class User : IdentityUser
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Gender { get; set; } = string.Empty;
    [Column(TypeName = "date")]
    public DateTime DateOfBirth { get; set; }=DateTime.Now;
    public int Owner { get; set; } = 0;
    [Column(TypeName = "date")]
    public DateTime EntryDate { get; set; }= DateTime.Now;

    [Column(TypeName = "decimal(10,2)")]
    public decimal TotalMoneySpent { get; set; }
    public string ProfileImage { get; set; } = string.Empty;
    public int AcountState { get; set; } = 0;

    //Navigation Property
    [JsonIgnore]
    public ICollection<Reviews> Reviews { get; set; } = new HashSet<Reviews>();

    [InverseProperty("Owner")]
    public ICollection<Property> OwnedProperties { get; set; } = new HashSet<Property>();
    public ICollection<Reservations> Reservations { get; set; } = new HashSet<Reservations>();
    public ICollection<User_Answer> UsersAnswer { get; set;} = new HashSet<User_Answer>();
}
