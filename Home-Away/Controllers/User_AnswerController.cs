using Home_Away.BL.Dtos.User_Answer_Dto;
using Home_Away.BL.Managers.User_Answer_Manager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Home_Away.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class User_AnswerController : ControllerBase
	{
		private readonly IUser_Answer_Manager user_Answer_Manager;
		public User_AnswerController(IUser_Answer_Manager user_Answer_Manager )
		{
			this.user_Answer_Manager = user_Answer_Manager;
		}

		[HttpGet]
		[Route("question/{id}")]
		public ActionResult<List<User_Answer_ReadDto>> GetAllUserAnswersByQuestionId(int id) 
		{
			return user_Answer_Manager.GetAllUserAnswerByQuestionId(id).ToList();
		}
		[HttpGet]
		[Route("user/{id}")]
		public ActionResult<List<User_Answer_ReadDto>> GetAllUserAnswersByUserId(string id)
		{
			return user_Answer_Manager.GetAllUserAnswerByUserId(id).ToList();
		}
		[HttpGet]
		[Route("answer/{questId}/{userId}")]
		public ActionResult<List<User_Answer_ReadDto>> GetAllUserAnswersByQuestionIdandUserId(int questId,string userId)
		{
			return user_Answer_Manager.GetUserAnswerByQuestionIdandUserId(questId,userId).ToList();
		}
		[HttpPost]
		public ActionResult AddAnswer(User_Answer_AddDto user_Answer)
		{
			user_Answer_Manager.AddUserAnswer(user_Answer);
			return NoContent();
		}




	}
}
