using Home_Away.BL.DTOS.QuestionDTOS;
using Home_Away.BL.Managers.QuestionManagers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Home_Away.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : Controller
    {
        private readonly IQuestionManager _questionManager;
        public QuestionsController(IQuestionManager questionManager)
        {
            _questionManager = questionManager;
        }

        [HttpGet]
        public ActionResult<IEnumerable<QuestionReadDTO>> GetAllQuestions()
        {
            return _questionManager.GetAllQuestions().ToList();
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<QuestionReadDTO> GetQuestionById(int id)
        {
            return _questionManager.GetQuestionById(id);
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult UpdateQuestion(QuestionUpdateDTO question)
        {
            var isFound = _questionManager.UpdateQuestion(question);
            if (!isFound)
            {
                return NotFound();
            }
            return Ok(isFound);// 200

        }
        [HttpPost]
        public ActionResult AddQuestion(QuestionAddDTO question)
        {
            var newId = _questionManager.AddQuestion(question);
            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult DeleteQuestion(int id)
        {
            _questionManager.DeleteQuestion(id);
            return NoContent();
        }
    }
}
