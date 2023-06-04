using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Home_Away.BL.Dtos.Property_Dto;
public class PropertyFilterDto
{
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

    [Column(TypeName = "decimal(10,2)")]
    public decimal AverageRating { get; set; }
}

