using Home_Away.BL.Dtos.User_Answer_Dto;
using Home_Away.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Away.BL.Managers.User_Answer_Manager
{
    public interface IUser_Answer_Manager
    {
        IEnumerable<User_Answer_ReadDto> GetAllUserAnswerByUserId(string UserId);
        IEnumerable<User_Answer_ReadDto> GetAllUserAnswerByQuestionId(int QuestionId);
        IEnumerable<User_Answer_ReadDto> GetUserAnswerByQuestionIdandUserId(int QuestionId, string userId);
        void AddUserAnswer(User_Answer_AddDto user_Answer);
    }
}
