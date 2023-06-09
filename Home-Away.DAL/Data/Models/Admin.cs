﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Home_Away.DAL;

public class Admin : IdentityUser
{
    [Column(TypeName = "date")] 
    public DateTime HiringDate { get; set; } = DateTime.Now;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Gender { get; set; } = string.Empty;
    [Column(TypeName = "date")] 
    public DateTime DateOfBirth { get; set; } = DateTime.Now;

    //NavigationProperties
    public ICollection<Property> ApprovedProperties { get; set; } = new HashSet<Property>();
    public ICollection<Reservations> ApprovedReservations { get; set; } = new HashSet<Reservations>();
    public ICollection<Reviews> ApprovedReviews { get; set; } = new HashSet<Reviews>();
}
