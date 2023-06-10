using Home_Away.BL;
using Home_Away.BL.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Home_Away.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : Controller
    {
        private readonly IReservationsManager _reservationsManager;
        public ReservationsController (IReservationsManager reservationsManager, TokenDto tokenDto)
        {
            _reservationsManager = reservationsManager;
        }

        [HttpGet]
        public ActionResult<List<ReservationReadDto>> GetAll()
        {
            return _reservationsManager.GetAll().ToList();
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<ReservationReadDto> GetById(int id)
        {
            ReservationReadDto? reservation = _reservationsManager.GetByID(id);
            if(reservation == null)
            {
                return NotFound();
            }
            return reservation;
        }
        [HttpPost]
        public ActionResult Add (ReservationsAddDto reservationDto)
        {
            var newId = _reservationsManager.AddReservation(reservationDto);
            return CreatedAtAction(nameof(GetById),
                                    new {id = newId}, 
                                    new GeneralResponse("Reservation has been added successfully"));
        }
        [HttpPut]
        public ActionResult Update (ReservationUpdateDto reservationDto)
        {
            var isFound = _reservationsManager.UpdateReservation(reservationDto);
            if (!isFound)
            {
                return NotFound();
            }
            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        //to be removed 
        public ActionResult Delete (int id)
        {
            var isFound = _reservationsManager.DeleteReservation(id);
            if (!isFound)
            {
                return NotFound();
            }
            return NoContent();
        }

        [HttpGet]
        [Route("user/{id}")]
        public ActionResult<List<ReservationReadDto>> GetAllReservationsByUserId (string id)
        {
            return _reservationsManager.GetAllReservationsByUserId(id).ToList();
        }

        [HttpGet]
        [Route("admin/{id}")]
        public ActionResult<List<ReservationReadDto>> GetAllReservationsByAdminId(string id)
        {
            return _reservationsManager.GetAllReservationsByAdminId(id).ToList();
        }

        [HttpGet]
        [Route("property/{id}")]
        public ActionResult<List<ReservationReadDto>> GetAllReservationsByPropertyId(int id)
        {
            return _reservationsManager.GetAllReservationsByPropertyId(id).ToList();
        }
        [HttpGet]
        [Route("daterange")]
        public ActionResult<List<ReservationReadDto>> GetAllReservationsByDateRange(DateTime fromDate, DateTime toDate)
        {
            return _reservationsManager.GetAllReservationsByDateRange(fromDate,toDate).ToList();
        }
        [HttpGet]
        [Route("owner/state/{state}")]
        public ActionResult<List<ReservationReadDto>> GetAllReservationsByOwnerState(string state)
        {
            return _reservationsManager.GetAllReservationsByOwnersState(state).ToList();
        }
        [HttpGet]
        [Route("admin/state/{state}")]
        public ActionResult<List<ReservationReadDto>> GetAllReservationsByAdminState(string state)
        {
            return _reservationsManager.GetAllReservationsByAdminId(state).ToList();
        }
        [HttpGet]
        [Route("user/{id}/daterange")]
        public ActionResult<List<ReservationReadDto>> GetAllReservationsByUserIdAndDateRange(string id, DateTime fromDate, DateTime toDate)
        {
            return _reservationsManager.GetAllReservationsByUserIdAndDateRange(id,fromDate,toDate).ToList();
        }
        [HttpGet]
        [Route("property/{id}/daterange")]
        public ActionResult<List<ReservationReadDto>> GetAllReservationsByPropertyIdAndDateRange(int id, DateTime fromDate, DateTime toDate)
        {
            return _reservationsManager.GetAllReservationsByPropertyIdAndDateRange(id, fromDate, toDate).ToList();
        }
        [HttpPut]   //7asaha enaha put 3alashan ana ba-update el status 
        [Route("owner/accept/{id}")]
        public ActionResult OwnerAcceptance (int reservationid , int transactionid)
        {
            ReservationReadDto? reservation = _reservationsManager.GetByID(reservationid);
            if (reservation == null)
            {
                return NotFound();
            }
            var OwnerId = _reservationsManager.GetPropertyOwner(reservationid);
            var UserId =User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)!.Value;   //User ID
            //User.FindFirstValue(ClaimTypes.NameIdentifier);
            if(OwnerId == UserId && transactionid != 0)
            {
                _reservationsManager.OwnerAcceptance(reservation.Id);
                return NoContent();
            }
            return BadRequest();   
        }

        [HttpPut]   //7asaha enaha put 3alashan ana ba-update el status 
        [Route("owner/refuse/{id}")]
        public ActionResult OwnerRefusal(int id)
        {
            ReservationReadDto? reservation = _reservationsManager.GetByID(id);
            if (reservation == null)
            {
                return NotFound();
            }
            _reservationsManager.OwnerRefusal(reservation.Id);
            return NoContent();
        }

        [HttpPut]   //7asaha enaha put 3alashan ana ba-update el status 
        [Route("admin/accept/{id}")]
        public ActionResult AdminAcceptance(int id)
        {
            ReservationReadDto? reservation = _reservationsManager.GetByID(id);
            if (reservation == null)
            {
                return NotFound();
            }
            _reservationsManager.AdminAcceptance(reservation.Id);
            return NoContent();
        }

        [HttpPut]   //7asaha enaha put 3alashan ana ba-update el status 
        [Route("admin/refuse/{id}")]
        public ActionResult AdminRefusal(int id)
        {
            ReservationReadDto? reservation = _reservationsManager.GetByID(id);
            if (reservation == null)
            {
                return NotFound();
            }
            _reservationsManager.AdminRefusal(reservation.Id);
            return NoContent();
        }
        [HttpPut]   //7asaha enaha put 3alashan ana ba-update el status 
        [Route("admin/refuse/{id}")]
        public ActionResult ReservationState(int id)
        {
            ReservationReadDto? reservation = _reservationsManager.GetByID(id);
            if (reservation == null)
            {
                return NotFound();
            }
            _reservationsManager.ReservationState(reservation.Id);
            return NoContent();
        }
    }
}
