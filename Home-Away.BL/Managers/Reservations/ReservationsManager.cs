using Home_Away.BL.Dtos;
using Home_Away.DAL;
namespace Home_Away.BL;
public class ReservationsManager : IReservationsManager
{
    //Constructor
    private readonly IReservationsRepo _reservationsRepo;
    public ReservationsManager (IReservationsRepo reservationsRepo)
    {
        _reservationsRepo= reservationsRepo;
    }
    //Methods Implementation
    public IEnumerable<ReservationReadDto> GetAll()
    {
        var reservationsFromDB = _reservationsRepo.GetAll();
        return reservationsFromDB.Select(r => new ReservationReadDto
        {
            Id = r.Id,
            RequestDate = r.RequestDate,
            DateFrom = r.DateFrom,
            DateTo = r.DateTo,
            StateFromOwner = r.StateFromOwner,
            StateFromAdmin = r.StateFromAdmin,
            PropertyId = r.PropertyId,
            AdminId = r.AdminId,
            UserId = r.UserId,
            ReservationState = r.ReservationState,
        });
    }
    public ReservationReadDto? GetByID(int id)
    {
        Reservations? reservationFromDB = _reservationsRepo.GetByID(id);
        if(reservationFromDB == null) { return null; }
        return new ReservationReadDto
        {
            Id = reservationFromDB.Id,
            RequestDate = reservationFromDB.RequestDate,
            DateFrom = reservationFromDB.DateFrom,
            DateTo = reservationFromDB.DateTo,
            StateFromOwner = reservationFromDB.StateFromOwner,
            StateFromAdmin = reservationFromDB.StateFromAdmin,
            PropertyId = reservationFromDB.PropertyId,
            AdminId = reservationFromDB.AdminId,
            UserId = reservationFromDB.UserId,
            ReservationState = reservationFromDB.ReservationState
        };
    }
    public int AddReservation(ReservationsAddDto reservation)
    {
        Reservations r = new Reservations
        {
            RequestDate = reservation.RequestDate,
            DateFrom = reservation.DateFrom,
            DateTo = reservation.DateTo,
            StateFromOwner = reservation.StateFromOwner,
            StateFromAdmin = reservation.StateFromAdmin,
            PropertyId = reservation.PropertyId,
            AdminId = reservation.AdminId,
            UserId = reservation.UserId,
            ReservationState = reservation.ReservationState 
        };
        _reservationsRepo.AddReservation(r);
        _reservationsRepo.SaveChanges();
        return r.Id;
    }
    public bool UpdateReservation(ReservationUpdateDto reservationFromRequest)
    {
        Reservations? reservation = _reservationsRepo.GetByID(reservationFromRequest.Id);
        if (reservation == null) { return false; }
        reservation.DateFrom = reservationFromRequest.DateFrom;
        reservation.DateTo = reservationFromRequest.DateTo;
        reservation.StateFromAdmin = reservationFromRequest.StateFromAdmin;
        reservation.StateFromOwner = reservationFromRequest.StateFromOwner;
        reservation.ReservationState = reservationFromRequest.ReservationState;
        reservation.PropertyId = reservationFromRequest.PropertyId;
        _reservationsRepo.UpdateReservation(reservation);
        _reservationsRepo.SaveChanges();
        return true;
    }
    public bool DeleteReservation(int id)
    {
        Reservations? reservation = _reservationsRepo.GetByID(id);
        if (reservation == null) { return false; }
        _reservationsRepo.DeleteReservation(reservation);
        _reservationsRepo.SaveChanges();
        return true;
    }
    public IEnumerable<ReservationReadDto> GetAllReservationsByUserId(string id)
    {
        var reservationsFromDB = _reservationsRepo.GetAllReservationsByUserId(id);
        return reservationsFromDB.Select(r => new ReservationReadDto 
        {
            Id = r.Id,
            RequestDate = r.RequestDate,
            DateFrom = r.DateFrom,
            DateTo = r.DateTo,
            StateFromOwner = r.StateFromOwner,
            StateFromAdmin = r.StateFromAdmin,
            PropertyId = r.PropertyId,
            AdminId = r.AdminId,
            UserId = r.UserId,
            ReservationState = r.ReservationState
        });
    }
    public IEnumerable<ReservationReadDto> GetAllReservationsByAdminId(string id)
    {
        var reservationsFromDB = _reservationsRepo.GetAllReservationsByUserId(id);
        return reservationsFromDB.Select(r => new ReservationReadDto
        {
            Id = r.Id,
            RequestDate = r.RequestDate,
            DateFrom = r.DateFrom,
            DateTo = r.DateTo,
            StateFromOwner = r.StateFromOwner,
            StateFromAdmin = r.StateFromAdmin,
            PropertyId = r.PropertyId,
            AdminId = r.AdminId,
            UserId = r.UserId,
            ReservationState = r.ReservationState
        });
    }
    public IEnumerable<ReservationReadDto> GetAllReservationsByPropertyId(int id)
    {
        var reservationsFromDB = _reservationsRepo.GetAllReservationsByPropertyId(id);
        return reservationsFromDB.Select(r => new ReservationReadDto
        {
            Id = r.Id,
            RequestDate = r.RequestDate,
            DateFrom = r.DateFrom,
            DateTo = r.DateTo,
            StateFromOwner = r.StateFromOwner,
            StateFromAdmin = r.StateFromAdmin,
            PropertyId = r.PropertyId,
            AdminId = r.AdminId,
            UserId = r.UserId,
            ReservationState = r.ReservationState
        });
    }
    public IEnumerable<ReservationReadDto> GetAllReservationsByDateRange(DateTime fromDate, DateTime toDate)
    {
        var reservationsFromDB = _reservationsRepo.GetAllReservationsByDateRange(fromDate,toDate);
        return reservationsFromDB.Select(r => new ReservationReadDto
        {
            Id = r.Id,
            RequestDate = r.RequestDate,
            DateFrom = r.DateFrom,
            DateTo = r.DateTo,
            StateFromOwner = r.StateFromOwner,
            StateFromAdmin = r.StateFromAdmin,
            PropertyId = r.PropertyId,
            AdminId = r.AdminId,
            UserId = r.UserId,
            ReservationState = r.ReservationState
        });
    }
    public IEnumerable<ReservationReadDto> GetAllReservationsByOwnersState(string state)
    {
        var reservationsFromDB = _reservationsRepo.GetAllReservationsByOwnersState(state);
        return reservationsFromDB.Select(r => new ReservationReadDto
        {
            Id = r.Id,
            RequestDate = r.RequestDate,
            DateFrom = r.DateFrom,
            DateTo = r.DateTo,
            StateFromOwner = r.StateFromOwner,
            StateFromAdmin = r.StateFromAdmin,
            PropertyId = r.PropertyId,
            AdminId = r.AdminId,
            UserId = r.UserId,
            ReservationState = r.ReservationState
        });
    }
    public IEnumerable<ReservationReadDto> GetAllReservationsByAdminsState(string state)
    {
        var reservationsFromDB = _reservationsRepo.GetAllReservationsByAdminsState(state);
        return reservationsFromDB.Select(r => new ReservationReadDto
        {
            Id = r.Id,
            RequestDate = r.RequestDate,
            DateFrom = r.DateFrom,
            DateTo = r.DateTo,
            StateFromOwner = r.StateFromOwner,
            StateFromAdmin = r.StateFromAdmin,
            PropertyId = r.PropertyId,
            AdminId = r.AdminId,
            UserId = r.UserId,
            ReservationState = r.ReservationState
        });
    }
    public IEnumerable<ReservationReadDto> GetAllReservationsByUserIdAndDateRange(string id, DateTime fromDate, DateTime toDate)
    {
        var reservationsFromDB = _reservationsRepo.GetAllReservationsByUserIdAndDateRange(id, fromDate, toDate);
        return reservationsFromDB.Select(r => new ReservationReadDto
        {
            Id = r.Id,
            RequestDate = r.RequestDate,
            DateFrom = r.DateFrom,
            DateTo = r.DateTo,
            StateFromOwner = r.StateFromOwner,
            StateFromAdmin = r.StateFromAdmin,
            PropertyId = r.PropertyId,
            AdminId = r.AdminId,
            UserId = r.UserId,
            ReservationState = r.ReservationState
        });
    }
    public IEnumerable<ReservationReadDto> GetAllReservationsByPropertyIdAndDateRange(int id, DateTime fromDate, DateTime toDate)
    {
        var reservationsFromDB = _reservationsRepo.GetAllReservationsByPropertyIdAndDateRange(id,fromDate,toDate);
        return reservationsFromDB.Select(r => new ReservationReadDto
        {
            Id = r.Id,
            RequestDate = r.RequestDate,
            DateFrom = r.DateFrom,
            DateTo = r.DateTo,
            StateFromOwner = r.StateFromOwner,
            StateFromAdmin = r.StateFromAdmin,
            PropertyId = r.PropertyId,
            AdminId = r.AdminId,
            UserId = r.UserId,
            ReservationState = r.ReservationState
        });
    }
    public void OwnerAcceptance(int id)
    {
        _reservationsRepo.OwnerAcceptance(id);
        _reservationsRepo.SaveChanges();
    }
    public void OwnerRefusal(int id)
    {
        _reservationsRepo.OwnerRefusal(id);
        _reservationsRepo.SaveChanges();
    }
    public void AdminAcceptance(int id)
    {
        _reservationsRepo.AdminAcceptance(id);
        _reservationsRepo.SaveChanges();
    }
    public void AdminRefusal(int id)
    {
        _reservationsRepo.AdminRefusal(id);
        _reservationsRepo.SaveChanges();
    }
    public void ReservationState(int id)
    {
        _reservationsRepo.ReservationState(id);
        _reservationsRepo.SaveChanges();
    }
}
