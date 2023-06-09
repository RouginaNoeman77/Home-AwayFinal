﻿using Home_Away.DAL;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Home_Away.BL.Dtos.Property_Dto;
public class PropertyAddDto
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
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
    public string OwnerId { get; set; }
    public string? AdminId { get; set; }

    public List<string> Prop_Images { get; set; }
}

