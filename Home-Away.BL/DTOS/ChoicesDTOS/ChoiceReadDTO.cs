
using Home_Away.DAL;
using System.ComponentModel.DataAnnotations.Schema;

namespace Home_Away.BL.DTOS
{
    public class ChoiceReadDTO
    {
        public int Id { get; set; }
        public string Text { get; set; } = string.Empty;
        public int QuestionsId { get; set; }
       
    }
}
