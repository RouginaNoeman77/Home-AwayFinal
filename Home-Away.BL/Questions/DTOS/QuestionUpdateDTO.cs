using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Away.BL
{
    public class QuestionUpdateDTO
    {
        public int QuestionsId { get; set; }
        public string QuestionText { get; set; } = string.Empty;
    }
}
