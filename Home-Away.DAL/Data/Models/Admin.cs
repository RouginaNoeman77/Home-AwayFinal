using Microsoft.AspNetCore.Identity;

namespace Home_Away.DAL;

public class Admin : IdentityUser
{
    public DateTime HiringDate { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Gender { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; }

    //NavigationProperties
    public ICollection<Property> ApprovedProperties { get; set; } = new HashSet<Property>();
    public ICollection<Reservations> ApprovedReservations { get; set; } = new HashSet<Reservations>();
    public ICollection<Reviews> ApprovedReviews { get; set; } = new HashSet<Reviews>();
}
