

using Home_Away.BL.Dtos;

namespace Home_Away.BL;

public interface IReviewsManager
{
    IEnumerable<ReviewsReadDto> GetAllReviews();
    IEnumerable<ReviewsReadDto> GetByDate(DateTime date);
    IEnumerable<ReviewsReadDto> GetByStatus(string status);
    IEnumerable<ReviewsReadDto> GetByPropertyId(int propertyid);
    IEnumerable<ReviewsReadDto> GetByUserId(string UserId);
    IEnumerable<ReviewsReadDto> GetByAdminId(string AdminId);

    ReviewsReadDto? GetReviewById(int id);
    int AddReview(ReviewsAddDto review);
    bool UpdateReview(ReviewUpdateDto review);
    bool DeleteReview(int id);
}
