using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Away.BL.DTOS.AdminDto
{
    public class AdminUpdateDto
    {
        public string AdminId { get; set; }
        public DateTime HiringDate { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
    }
}
