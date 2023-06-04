
namespace Home_Away.DAL;
    public class ReservationsRepo:IReservationsRepo
{

    //Constructor
    private readonly UserContext _context;
    public ReservationsRepo(UserContext context)
    {
        _context = context;
    }
    //Methods Implementation
    //-----CRUD
    public IEnumerable<Reservations> GetAll()
    {
        return _context.Set<Reservations>();
    }
    public Reservations? GetByID(int id)
    {
        return _context.Set<Reservations>().Find(id);
    }
    public void AddReservation(Reservations reservation)
    {
        _context.Set<Reservations>().Add(reservation);
    }
    public void UpdateReservation(Reservations reservation)
    {
        //No Implementation----Entity Framework works as a tracking system
    }
    public void DeleteReservation(Reservations reservation)
    {
        _context.Set<Reservations>().Remove(reservation);
    }
    //-----Saving Method
    public int SaveChanges()
    {
        return _context.SaveChanges();
    }
    //-----Extra Methods Needed In Business Logic
    //Admin's Operation
    public void AdminAcceptance(int id)
    {
        var reservation = _context.Set<Reservations>().Find(id);
        if (reservation != null)
        {
            reservation.StateFromAdmin = "Accepted";
        }
    }
    public void AdminRefusal(int id)
    {
        var reservation = _context.Set<Reservations>().Find(id);
        if (reservation != null)
        {
            reservation.StateFromAdmin = "Refused";
        }
    }
    //Owner's Operation
    public void OwnerAcceptance(int id)
    {
        var reservation = _context.Set<Reservations>().Find(id);
        if (reservation != null)
        {
            reservation.StateFromOwner = "Accepted";
        }
    }
    public void OwnerRefusal(int id)
    {
        var reservation = _context.Set<Reservations>().Find(id);
        if (reservation != null)
        {
            reservation.StateFromOwner = "Refused";
        }
    }
    //Getting All Reservations Of A Specific User
    public IEnumerable<Reservations> GetAllReservationsByUserId(string id)
    {
        return _context.Set<Reservations>().Where(r => r.UserId == id).ToList();
    }
    //Getting All Reservations Handled By Specific Admin
    public IEnumerable<Reservations> GetAllReservationsByAdminId(string id)
    {
        return _context.Set<Reservations>().Where(r => r.AdminId == id).ToList();
    }
    //Getting All Reservations Of A Specific Property
    public IEnumerable<Reservations> GetAllReservationsByPropertyId(int id)
    {
        return _context.Set<Reservations>().Where(r => r.PropertyId == id).ToList();
    }
    //Getting All Reservations During Specific Date Ranges
    public IEnumerable<Reservations> GetAllReservationsByDateRange(DateTime fromDate, DateTime toDate)
    {
        return _context.Set<Reservations>().Where(r => r.DateFrom >= fromDate && r.DateTo <= toDate).ToList();
    }
    //Getting All Reservations According To Owner's State
    public IEnumerable<Reservations> GetAllReservationsByOwnersState(string state)
    {
        return _context.Set<Reservations>().Where(r => r.StateFromOwner == state).ToList();
    }
    //Getting All Reservations According To Admin's State
    public IEnumerable<Reservations> GetAllReservationsByAdminsState(string state)
    {
        return _context.Set<Reservations>().Where(r => r.StateFromAdmin == state).ToList();
    }
    //Getting All Reservations Of A Specific User & In A Specific Date Range
    public IEnumerable<Reservations> GetAllReservationsByUserIdAndDateRange(string id, DateTime fromDate, DateTime toDate)
    {
        return _context.Set<Reservations>().Where(r => r.UserId == id && r.DateFrom >= fromDate && r.DateTo <= toDate).ToList();
    }
    //Getting All Reservations Of A Specific Property & In A Specific Date Range
    public IEnumerable<Reservations> GetAllReservationsByPropertyIdAndDateRange(int id, DateTime fromDate, DateTime toDate)
    {
        return _context.Set<Reservations>().Where(r => r.PropertyId == id && r.DateFrom >= fromDate && r.DateTo <= toDate).ToList();
    }
}
   
