using Home_Away.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Away.BL.DTOS.QuestionDTOS
{
    public class QuestionReadDTO
    {
        public int QuestionId { get; set; } 
        public string QuestionText { get; set; } = string.Empty;
        public ICollection<Choices> choices { get; set; } = new HashSet<Choices>();
    }
}
