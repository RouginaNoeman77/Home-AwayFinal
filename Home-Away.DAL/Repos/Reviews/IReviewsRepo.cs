
namespace Home_Away.DAL;
    public interface IReviewsRepo
    {

    IEnumerable<Reviews> GetReviews();
    Reviews? GetReviewbyId(int id);

    IEnumerable<Reviews> GetReviewsByDate(DateTime datefrom);

    IEnumerable<Reviews> GetReviewsByStatus(string status);

    IEnumerable<Reviews> GetReviewsByPropertyId(int propertyId);
    IEnumerable<Reviews> GetReviewsByUserId(string UserId);
    IEnumerable<Reviews> GetReviewsByAdminId(string AdminId);


    int AddReview(Reviews review);
    void UpdateReview(Reviews review);

    int DeleteReview(Reviews review);

    int SaveChanges();
}
