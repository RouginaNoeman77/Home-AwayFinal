

using Home_Away.BL.Dtos;
using Home_Away.DAL;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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
            AdminId = reviewfromrequest.AdminId,
            UserId = reviewfromrequest.UserId,
            PropertyId = reviewfromrequest.PropertyId,
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

 

    public IEnumerable<ReviewsReadDto> GetByDate(DateTime date)
    {
        var ReviewFromDatabase = _ReviewsRepo.GetReviewsByDate(date);
        return ReviewFromDatabase.Select(review => new ReviewsReadDto
        {
            Id = review.Id,
            Rating = review.Rating,
            ReviewText = review.ReviewText,
            ReviewDate = review.ReviewDate,
            State = review.State,
        });
    }

    public IEnumerable<ReviewsReadDto> GetByStatus(string status)
    {

        var ReviewFromDatabase = _ReviewsRepo.GetReviewsByStatus(status);
        return ReviewFromDatabase.Select(review => new ReviewsReadDto
        {
            Id = review.Id,
            Rating = review.Rating,
            ReviewText = review.ReviewText,
            ReviewDate = review.ReviewDate,
            State = review.State,
        });
    }

    public IEnumerable<ReviewsReadDto> GetByPropertyId(int propertyid)
    {
        var ReviewFromDatabase = _ReviewsRepo.GetReviewsByPropertyId(propertyid);
        return ReviewFromDatabase.Select(review => new ReviewsReadDto
        {
            Id = review.Id,
            Rating = review.Rating,
            ReviewText = review.ReviewText,
            ReviewDate = review.ReviewDate,
            State = review.State,
            UserId = review.UserId
        });
    }

    public IEnumerable<ReviewsReadDto> GetByUserId(string UserId)
    {
        var ReviewFromDatabase = _ReviewsRepo.GetReviewsByUserId(UserId);
        return ReviewFromDatabase.Select(review => new ReviewsReadDto
        {
            Id = review.Id,
            Rating = review.Rating,
            ReviewText = review.ReviewText,
            ReviewDate = review.ReviewDate,
            State = review.State,
          
        });

    }

    public IEnumerable<ReviewsReadDto> GetByAdminId(string AdminId)
    {
        var ReviewFromDatabase = _ReviewsRepo.GetReviewsByAdminId(AdminId);
        return ReviewFromDatabase.Select(review => new ReviewsReadDto
        {
            Id = review.Id,
            Rating = review.Rating,
            ReviewText = review.ReviewText,
            ReviewDate = review.ReviewDate,
            State = review.State,
        });
    }
}
