
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

    string AddUser(User entity);
    void UpdateUser(User entity);
    void DeleteUser(User entity);
    int SaveChanges();
}
    
