

using Home_Away.BL.Dtos;
using Home_Away.DAL;

namespace Home_Away.BL;

public class ReviewsManager : IReviewsManager
{
    private readonly IReviewsRepo _ReviewsRepo;

    public ReviewsManager(IReviewsRepo reviewsRepo)
    {
        _ReviewsRepo = reviewsRepo;
    }

    public IEnumerable<ReviewsReadDto> GetAllReviews()
    {
        var ReviewFromDatabase = _ReviewsRepo.GetReviews();
        return ReviewFromDatabase.Select(review => new ReviewsReadDto
        {
            Id = review.Id,
            Rating = review.Rating,
            ReviewText = review.ReviewText,
            ReviewDate = review.ReviewDate,
            State=review.State,
        });
    }

    public ReviewsReadDto? GetReviewById(int id)
    {
        Reviews? reviewfromdatabase = _ReviewsRepo.GetReviewbyId(id);
        if(reviewfromdatabase == null)
        {
            return null;
        }

        return new ReviewsReadDto
        {

            Rating = reviewfromdatabase.Rating,
            ReviewText = reviewfromdatabase.ReviewText,
            ReviewDate = reviewfromdatabase.ReviewDate,
            State = reviewfromdatabase.State,
        };
    }
    public int AddReview(ReviewsAddDto reviewfromrequest)
    {
        Reviews review = new Reviews
        {
            
            Rating = reviewfromrequest.Rating,
            ReviewText = reviewfromrequest.ReviewText,
            ReviewDate = reviewfromrequest.ReviewDate,
            State = reviewfromrequest.State,
        };
        _ReviewsRepo.AddReview(review);
        _ReviewsRepo.SaveChanges();
        return review.Id;
    }

    public bool DeleteReview(int id)
    {
        Reviews? review = _ReviewsRepo.GetReviewbyId(id);
        if (review == null)
        {
            return false;
        }
        _ReviewsRepo.DeleteReview(review);
        _ReviewsRepo.SaveChanges();
        return true;

    }

   

    public bool UpdateReview(ReviewUpdateDto reviewfromrequest)
    {
        Reviews? review = _ReviewsRepo.GetReviewbyId(reviewfromrequest.Id);
            if(review == null)
            {
                return false;
            }

            review.State = reviewfromrequest.State;
        review.ReviewText = reviewfromrequest.ReviewText;
        _ReviewsRepo.UpdateReview(review);
        _ReviewsRepo.SaveChanges();
        return true;
    }
}
