using Home_Away.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Away.BL.DTOS.ChoicesDTOS
{
    public class ChoiceAddDTO
    {
        public string Text { get; set; } = string.Empty;    
        public int QuestionsId { get; set; }     

    }
}
