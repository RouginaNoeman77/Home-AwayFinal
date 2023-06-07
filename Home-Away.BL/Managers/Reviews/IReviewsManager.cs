

using Home_Away.BL.Dtos;

namespace Home_Away.BL;

public interface IReviewsManager
{
    IEnumerable<ReviewsReadDto> GetAllReviews();
    ReviewsReadDto? GetReviewById(int id);
    int AddReview(ReviewsAddDto review);
    bool UpdateReview(ReviewUpdateDto review);
    bool DeleteReview(int id);
}
