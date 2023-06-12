using Home_Away.BL.Dtos;
using Home_Away.DAL;

namespace Home_Away.BL;
public interface IReservationsManager
{
    IEnumerable<ReservationReadDto> GetAll();
    ReservationReadDto? GetByID(int id);
    int AddReservation(ReservationsAddDto reservation);
    bool UpdateReservation(ReservationUpdateDto reservation);
    bool DeleteReservation(int id);
    IEnumerable<ReservationReadDto> GetAllReservationsByUserId(string id);
    IEnumerable<ReservationReadDto> GetAllReservationsByAdminId(string id);
    IEnumerable<ReservationReadDto> GetAllReservationsByPropertyId(int id);
    IEnumerable<ReservationReadDto> GetAllReservationsByDateRange(DateTime fromDate, DateTime toDate);
    IEnumerable<ReservationReadDto> GetAllReservationsByOwnersState(string state);
    IEnumerable<ReservationReadDto> GetAllReservationsByAdminsState(string state);
    IEnumerable<ReservationReadDto> GetAllReservationsByUserIdAndDateRange(string id, DateTime fromDate, DateTime toDate);
    IEnumerable<ReservationReadDto> GetAllReservationsByPropertyIdAndDateRange(int id, DateTime fromDate, DateTime toDate);
    public void OwnerAcceptance(int id);
    void OwnerRefusal(int id);
    void AdminAcceptance(int id);
    void AdminRefusal(int id);
    void ReservationState(int id);
    string GetPropertyOwner(int id);
}
