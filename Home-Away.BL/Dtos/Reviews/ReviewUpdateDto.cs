﻿

namespace Home_Away.BL.Dtos;

public class ReviewUpdateDto
{
    public int Id { get; set; }
    public string ReviewText { get; set; }=string.Empty;
    public decimal Rating { get; set; }
    //public DateTime ReviewDate { get; set; }

    public string State { get; set; } = "pending";
    //public int PropertyId { get; set; }
    //public Property Property { get; set; }

    //[ForeignKey("Admin")]
    //public string? AdminId { get; set; } //for Approve
    //public Admin Admin { get; set; }

    //[ForeignKey("User")]
   // public string? UserId { get; set; } //for Rent
    //public User User { get; set; }
}
