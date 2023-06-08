using Home_Away.BL.Dtos;
using Home_Away.BL.DTOS.AdminDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Away.BL.Managers.Admin_Manager
{
    public interface IAdminManager
    {
        IEnumerable<AdminReadDto> GetAllAdmins();
        AdminReadDto? GetAdminById(string id);      
        string AddAdmin(AdminAddDto admin);
        bool UpdateAdmin(AdminUpdateDto admin);
        bool DeleteAdmin(string id);
    }
}
