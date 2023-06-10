namespace Home_Away.DAL;
public interface IReservationsRepo
{
    IEnumerable<Reservations> GetAll();
    Reservations? GetByID(int id);
    void AddReservation(Reservations reservation);
    void UpdateReservation(Reservations reservation);
    void DeleteReservation(Reservations reservation);
    int SaveChanges();
    void OwnerAcceptance(int id);
    void OwnerRefusal(int id);
    void AdminAcceptance(int id);
    void AdminRefusal(int id);
    void ReservationState(int id);
    string GetPropertyOwner(int id);
    IEnumerable<Reservations> GetAllReservationsByUserId(string id);
    IEnumerable<Reservations> GetAllReservationsByAdminId(string id);
    IEnumerable<Reservations> GetAllReservationsByPropertyId(int id);
    IEnumerable<Reservations> GetAllReservationsByDateRange(DateTime fromDate, DateTime toDate);
    IEnumerable<Reservations> GetAllReservationsByOwnersState(string state);
    IEnumerable<Reservations> GetAllReservationsByAdminsState(string state);
    IEnumerable<Reservations> GetAllReservationsByUserIdAndDateRange(string id, DateTime fromDate, DateTime toDate);
    IEnumerable<Reservations> GetAllReservationsByPropertyIdAndDateRange(int id, DateTime fromDate, DateTime toDate);
}
    
