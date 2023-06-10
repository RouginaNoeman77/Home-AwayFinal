using Home_Away.BL.Dtos;
using Home_Away.BL.Dtos.Login;
using Home_Away.BL.Managers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace Home_Away.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUsersManagers _usersManagers;

        public UserController(IUsersManagers usersManagers)
        {
            _usersManagers = usersManagers;
        }
        [HttpGet]
        public ActionResult<List<UserReadDto>> GetAllUsers()
        {
            return _usersManagers.GetAllUsers().ToList();
        }
        [HttpGet]
        [Route("{id}")]
        public ActionResult<UserReadDto> GetUserById(string id)
        {
            UserReadDto? user = _usersManagers.GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }
            return user;
        }

        [HttpPost]
        public ActionResult Add(UserAddDto user)
        {
            var newId = _usersManagers.Add(user);
            return CreatedAtAction(nameof(GetUserById),
                                    new { id = newId },
                                    new { message = "User has been added successfully" });
        }

        [HttpPut]
        public ActionResult Update(UserUpdateDto user)
        {
            var isFound = _usersManagers.Update(user);
            if (!isFound)
            {
                return NotFound();
            }
            return NoContent();
        }
        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete(string id)
        {
            var isFound = _usersManagers.Delete(id);
            if (!isFound)
            {
                return NotFound();
            }
            return NoContent();
        }
        [HttpGet]
        [Route("user/{role}")]
        public ActionResult<List<UserReadDto>> GetUsersByRole(string role)
        {
            return _usersManagers.GetUsersByRole(role).ToList();
        }
        [HttpGet]
        [Route("renters")]
        public ActionResult<List<UserReadDto>> GetAllRenters()
        {
            return _usersManagers.GetAllRenters().ToList();
        }
        [HttpGet]
        [Route("owners")]
        public ActionResult<List<UserReadDto>> GetAllOwners()
        {
            return _usersManagers.GetAllUsers().ToList();
        }
        [HttpGet]
        [Route("user/ownedProperties/{id}")]
        public ActionResult<UserReadDto> GetUserWithOwnedProperties(string id)
        {
            UserReadDto? user = _usersManagers.GetUserWithAllOwnedProperties(id);
            if (user == null)
            {
                return NotFound();
            }
            return user;
        }
        [HttpGet]
        [Route("user/reservations/{id}")]
        public ActionResult<UserReadDto> GetUserWithAllReservations(string id)
        {
            UserReadDto? user = _usersManagers.GetUserWithAllReservations(id);
            if (user == null)
            {
                return NotFound();
            }
            return user;
        }
        [HttpGet]
        [Route("user/reviews/{id}")]
        public ActionResult<UserReadDto> GetUserWithAllReviews(string id)
        {
            UserReadDto? user = _usersManagers.GetUserWithAllReviews(id);
            if (user == null)
            {
                return NotFound();
            }
            return user;
        }
        [HttpGet]
        [Route("user/answers/{id}")]
        public ActionResult<UserReadDto> GetUserWithAllQuestionsAnswers(string id)
        {
            UserReadDto? user = _usersManagers.GetUserWithAllQuestionsAnswers(id);
			if (user == null)
			{
				return NotFound();
			}
            return user;

		}
	}
}
