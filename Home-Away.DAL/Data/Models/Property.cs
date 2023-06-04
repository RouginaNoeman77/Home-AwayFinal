﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace Home_Away.DAL;

public class Property
{
    public int Id { get; set; }
    public string Title { get; set; }=string.Empty;
    public string Description { get; set; }= string.Empty;
    public string Address { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public string Region { get; set; } = string.Empty;
    public string Area { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;

    [Column(TypeName = "decimal(10,2)")]
    public decimal PricePerNight { get; set; }
    public int Capacity { get; set; }
    public int NumberOfRooms { get; set; }
    public int NumberOfBathrooms { get; set; }
    public int NumberOfFloors { get; set; }
    public DateTime DateOfAddingProperty { get; set; }
    public string State { get; set; } = "Pending";
    [Column(TypeName = "decimal(10,2)")]
    public decimal AverageRating { get; set; }

    //Navigation Property 

    [ForeignKey("User")]
    public string OwnerId { get; set; }
    public User Owner { get; set; }

    [ForeignKey("Admin")]
    public string AdminId { get; set; }
    public Admin Admin { get; set; }

    public ICollection<Reservations> Reservations { get; set; } = new HashSet<Reservations>();
    public ICollection<Reviews> Reviews { get; set; } = new HashSet<Reviews>();

    
    //public List<Image> Images { get; set; } = new List<Image>();


}