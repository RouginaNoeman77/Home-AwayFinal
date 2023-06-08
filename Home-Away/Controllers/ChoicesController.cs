using Home_Away.BL.DTOS.ChoicesDTOS;
using Home_Away.BL.DTOS;
using Home_Away.BL.Managers.ChoiceManagers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Home_Away.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChoicesController : Controller
    {
        private readonly IChoiceManager _choiceManager;

        public ChoicesController(IChoiceManager choiceManager)
        {
            _choiceManager = choiceManager;
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<IEnumerable<ChoiceReadDTO>> GetAllChoicesByQuestionId(int id)
        {
            return _choiceManager.GetAllChoicesByQuestionId(id).ToList();
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<ChoiceReadDTO> GetChoiceById(int id)
        {
            return _choiceManager.GetChoiceById(id);
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult UpdateQChoice(ChoiceUpdateDTO choice)
        {
            var isFound = _choiceManager.UpdateChoice(choice);
            if (!isFound)
            {
                return NotFound();
            }
            return Ok(isFound);// 200

        }
        [HttpPost]
        public ActionResult AddChoice(ChoiceAddDTO choice)
        {
            var newId = _choiceManager.AddChoice(choice);
            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult DeleteChoice(int id)
        {
            _choiceManager.DeleteChoice(id);
            return NoContent();
        }
    }
}
