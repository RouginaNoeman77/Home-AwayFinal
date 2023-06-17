using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Away.BL.DTOS.AdminDto
{
    public class AdminUpdateDto
    {
        public string AdminId { get; set; }
        [Column(TypeName = "date")]
        public DateTime HiringDate { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        [Column(TypeName = "date")]
        public DateTime DateOfBirth { get; set; }
    }
}
