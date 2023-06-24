using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Text.Json.Serialization;

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
    [Column(TypeName = "date")]
    public DateTime DateOfAddingProperty { get; set; } = DateTime.Now;
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
    [JsonIgnore]
    public List<Reviews> Prop_Reviews { get; set; } = new List<Reviews>();

	[JsonIgnore]
	public List<Images>? Prop_Images { get; set; } = new List<Images>();

}
