using Home_Away.BL.DTOS.AdminDto;
using Home_Away.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Away.BL.Managers.Admin_Manager
{
    public class AdminManager : IAdminManager
    {
        private readonly IAdminRepo _adminRepo;

        public AdminManager(IAdminRepo adminRepo)
        {
            _adminRepo = adminRepo;

        }

        public string AddAdmin(AdminAddDto admin)
        {
            Admin a = new Admin
            {
                FirstName = admin.FirstName,
                LastName = admin.LastName,
                Gender = admin.Gender,
                HiringDate = admin.HiringDate,
                DateOfBirth = admin.DateOfBirth
            };
            return a.Id;
        }

        public bool DeleteAdmin(string id)
        {

            Admin? admin = _adminRepo.GetAdminById(id);
            if (admin == null) { return false; }
            _adminRepo.DeleteAdmin(admin);
            _adminRepo.SaveChanges();
            return true;
        }

        public AdminReadDto? GetAdminById(string id)
        {
            Admin? admin= _adminRepo.GetAdminById(id);
            if(admin == null) { return null;}
            return new AdminReadDto
            {
                AdminId = admin.Id,
                FirstName = admin.FirstName,
                LastName = admin.LastName,
                Gender = admin.Gender,
                HiringDate = admin.HiringDate,
                DateOfBirth = admin.DateOfBirth
            };
        }

        public IEnumerable<AdminReadDto> GetAllAdmins()
        {
           var adminsFromDb= _adminRepo.GetAllAdmins();
            return adminsFromDb.Select(s => new AdminReadDto
            {
                AdminId=s.Id,
                FirstName=s.FirstName,
                LastName=s.LastName,
                Gender=s.Gender,
                HiringDate=s.HiringDate,
                DateOfBirth=s.DateOfBirth
            });
        }

        public bool UpdateAdmin(AdminUpdateDto admin)
        {
            Admin? adminFromDb =_adminRepo.GetAdminById(admin.AdminId);
            if(admin == null)
            {
                return false;
            }
            adminFromDb.FirstName=admin.FirstName;
            adminFromDb.LastName=admin.LastName;
            adminFromDb.Gender=admin.Gender;
            adminFromDb.DateOfBirth=admin.DateOfBirth;
            adminFromDb.HiringDate=admin.HiringDate;
            _adminRepo.UpdateAdmin(adminFromDb);
            _adminRepo.SaveChanges();
            return true;

        }
    }
}
