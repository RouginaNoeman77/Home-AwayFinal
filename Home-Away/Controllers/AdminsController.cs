using Home_Away.BL.Dtos;
using Home_Away.BL.DTOS.AdminDto;
using Home_Away.BL.Managers.Admin_Manager;
using Home_Away.DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Home_Away.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminsController : ControllerBase
    {
        private readonly IAdminManager _adminManager;

        public AdminsController (IAdminManager adminManager)
        {
            _adminManager = adminManager;
        }

        [HttpGet]
        public ActionResult<IEnumerable<AdminReadDto>> GetAllAdmins() 
        {
            return _adminManager.GetAllAdmins().ToList();

        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<AdminReadDto> GetAdminById(string id)
        {
            AdminReadDto? admin = _adminManager.GetAdminById(id);
            if (admin == null)
            {
                return NotFound();
            }
            return admin;

        }

        [HttpPost]
        public ActionResult AddAdmin(AdminAddDto admin)
        {
            var newId = _adminManager.AddAdmin(admin);
            return CreatedAtAction(nameof(GetAdminById),
                                    new { id = newId },
                                    new { message = "User has been added successfully" });
        }

        [HttpPut]
        public ActionResult UpdateAdmin(AdminUpdateDto admin)
        {
            var isFound = _adminManager.UpdateAdmin(admin);
            if (!isFound)
            {
                return NotFound();
            }
            return NoContent();
        }

        [HttpDelete]
        public ActionResult DeleteAdmin(string id)
        {
            var isFound = _adminManager.DeleteAdmin(id);
            if (!isFound)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
