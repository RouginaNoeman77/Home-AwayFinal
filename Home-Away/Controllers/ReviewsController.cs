using Home_Away.BL;
using Home_Away.BL.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Home_Away.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly IReviewsManager _ReviewsManager;

        public ReviewsController(IReviewsManager reviewsManager)
        {
            _ReviewsManager = reviewsManager;
        }
        [HttpGet]
        public ActionResult<List<ReviewsReadDto>> GetAll()
        {
            return _ReviewsManager.GetAllReviews().ToList();
        }
        [HttpGet]
        [Route("{id}")]
        public ActionResult<ReviewsReadDto> GetById(int id)
        {
            ReviewsReadDto? review = _ReviewsManager.GetReviewById(id);
            if(review == null) { return NotFound(); }
            return review;
        }

        [HttpGet]
        [Route("property/{id}")]
        public ActionResult<List<ReviewsReadDto>> GetByPropertyId(int id)
        {
            return _ReviewsManager.GetByPropertyId(id).ToList();
          
        }

        [HttpGet]
        [Route("user/{id}")]
        public ActionResult<List<ReviewsReadDto>> GetByUserId(string id)
        {
            return _ReviewsManager.GetByUserId(id).ToList();

        }

        [HttpGet]
        [Route("Admin/{id}")]
        public ActionResult<List<ReviewsReadDto>> GetByAdminId(string id)
        {
            return _ReviewsManager.GetByAdminId(id).ToList();

        }
        [HttpGet]
        [Route("date/{date}")]
        public ActionResult<List<ReviewsReadDto>> GetByDate(DateTime date)
        {
            return _ReviewsManager.GetByDate(date).ToList();

        }

        [HttpGet]
        [Route("status/{status}")]
        public ActionResult<List<ReviewsReadDto>> GetByStatus(string status)
        {
            return _ReviewsManager.GetByStatus(status).ToList();

        }



        [HttpPost]
        public ActionResult Add (ReviewsAddDto review)
        {
            var newid = _ReviewsManager.AddReview(review);
            return CreatedAtAction(nameof(GetById), 
                                    new { id = newid },
                                    new GeneralResponse("Review has been added successfully"));
        }
        [HttpPut]
        public ActionResult Update(ReviewUpdateDto review)
        {
            var isfound = _ReviewsManager.UpdateReview(review);
            if(isfound) { return NoContent(); }
            return NotFound();
        }
        [HttpDelete]
        [Route("delete/{id}")]
        public ActionResult Delete(int id)
        {
            var isfound = _ReviewsManager.DeleteReview(id);
            if (isfound) { return NoContent(); }
            return NotFound();
        }
    }
}
