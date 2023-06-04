
namespace Home_Away.DAL;
public interface IUserRepo
{

    IEnumerable<User> GetAllUsers();
    User? GetUserById(string id);
    IEnumerable<User> GetUsersByRole(string role);
    IEnumerable<User> GetAllOwners();
    IEnumerable<User> GetAllRenters();
    User? GetUserWithAllOwnedProperties(string id);
    User? GetUserWithAllReservations(string id);
    User? GetUserWithAllReviews(string id);
    User? GetUserWithAllQuestionsAnswers(string id);

    void Add(User entity);
    void Update(User entity);
    void Delete(User entity);

    int SaveChanges();
}
    
