namespace Home_Away.DAL
{
    public class ReviewsRepo : IReviewsRepo
    {
        private readonly UserContext _context;

        public ReviewsRepo(UserContext context)
        {
            _context = context;
        }

        public IEnumerable<Reviews> GetReviews()
        {
            return _context.Set<Reviews>();
        }

        public Reviews? GetReviewbyId(int id)
        {
            return _context.Set<Reviews>().Find(id);
        }

        public IEnumerable<Reviews> GetReviewsByDate(DateTime datefrom)
        {
            return _context.Set<Reviews>().Where(a => a.ReviewDate > datefrom);
        }

        public IEnumerable<Reviews> GetReviewsByStatus(string status)
        {
            return _context.Set<Reviews>().Where(a => a.State == status);
        }

        public int AddReview(Reviews review)
        {
            _context.Add(review);
            SaveChanges();
            return 1;
        }

        public int DeleteReview(Reviews review)
        {
            _context.Set<Reviews>().Remove(review);
            return 1;
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void UpdateReview(Reviews review)
        {
            // Works by tracking, so no need to implement code
        }

        public IEnumerable<Reviews> GetReviewsByPropertyId(int propertyId)
        {
            return _context.Set<Reviews>().Where(review => review.PropertyId == propertyId);
        }

        public IEnumerable<Reviews> GetReviewsByUserId(string UserId)
        {
            return _context.Set<Reviews>().Where(review => review.UserId == UserId);
        }

        public IEnumerable<Reviews> GetReviewsByAdminId(string AdminId)
        {
            return _context.Set<Reviews>().Where(review => review.AdminId == AdminId);
        }
    }
}
