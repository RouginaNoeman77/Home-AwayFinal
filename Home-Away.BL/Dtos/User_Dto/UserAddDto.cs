
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Home_Away.BL.Dtos;

public class UserAddDto
{
    public string UserName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Gender { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; }
	public string Email { get; set; } = string.Empty;
	public string Password  { get; set; } = string.Empty;
	// public int Owner { get; set; } = 0;
	// public DateTime EntryDate { get; set; }

	//[Column(TypeName = "decimal(10,2)")]
	// public decimal TotalMoneySpent { get; set; }
	public string ProfileImage { get; set; } = string.Empty;
    //public int AcountState { get; set; } = 1;
}
