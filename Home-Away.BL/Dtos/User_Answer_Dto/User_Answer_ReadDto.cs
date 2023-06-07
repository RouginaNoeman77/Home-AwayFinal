using Home_Away.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Away.BL.Dtos.User_Answer_Dto
{
    public class User_Answer_ReadDto
    {
        public string UserAnswers { get; set; } = string.Empty;
        public string UserId { get; set; }
        public int QuestionsId { get; set; }
    }
}
