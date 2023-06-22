
﻿
using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;

namespace Home_Away.DAL;
public class AdminRepo : IAdminRepo
{
    private readonly UserContext _userContext;

    public AdminRepo(UserContext userContext)
    {
        _userContext = userContext;
    }


    public string AddAdmin(Admin admin)
    {
        _userContext.Set<Admin>().Add(admin);

        return admin.Id;
    }

  

    public void UpdateAdmin(Admin admin)
    {
        //
    }

    public IEnumerable<Admin> GetAllAdmins()
    {
        return _userContext.Set<Admin>().ToList();
    }

    public Admin? GetAdminById(string id)
    {
        return _userContext.Set<Admin>().Find(id);
    }

    public void DeleteAdmin(Admin entity)
    {
        _userContext.Set<Admin>().Remove(entity);
    }

    public int SaveChanges()
    {
       return _userContext.SaveChanges();
    }

  
}



      
    

  


