
using Microsoft.EntityFrameworkCore;

namespace Home_Away.DAL;

public class UserRepo:IUserRepo
{

    private readonly UserContext _context;
    public UserRepo(UserContext context)
    {
        _context = context;
    }
    public string AddUser(User entity)
    {
        _context.Set<User>().Add(entity);

        return entity.Id;
    }

    public void DeleteUser(User entity)
    {
        _context.Set<User>().Remove(entity);
       
    }

    public IEnumerable<User> GetAllOwners()
    {
        return _context.Set<User>().Where(a => a.Owner == 1).ToList();
    }

    public IEnumerable<User> GetAllRenters()
    {
        return _context.Set<User>().Where(a => a.Owner == 0).ToList();
    }

    public IEnumerable<User> GetAllUsers()
    {
        return _context.Set<User>().AsNoTracking();
    }

    public User? GetUserById(string id)
    {
        return _context.Set<User>().Find(id);
    }

    public IEnumerable<User> GetUsersByRole(string role)
    {
        return _context.Set<User>().Where(a => a.GetType().ToString() == role).ToList();
    }

    public User? GetUserWithAllOwnedProperties(string id)
    {
        return _context._users
            .Include(a => a.OwnedProperties)
            .FirstOrDefault(a => a.Id == id);
    }

    public User? GetUserWithAllReservations(string id)
    {
        return _context._users
           .Include(a => a.Reservations)
           .FirstOrDefault(a => a.Id == id);
    }
    public User? GetUserWithAllReviews(string id)
    {
        return _context._users
           .Include(a => a.Reviews)
           .FirstOrDefault(a => a.Id == id);
    }
    public User? GetUserWithAllQuestionsAnswers(string id)
    {
        return _context._users
           .Include(a => a.UsersAnswer)
           .FirstOrDefault(a => a.Id == id);
    }

    public int SaveChanges()
    {
        return _context.SaveChanges();
    }




    public void UpdateUser(User entity)
    {

    }
}
