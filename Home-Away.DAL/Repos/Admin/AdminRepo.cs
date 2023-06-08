namespace Home_Away.DAL;

public class AdminRepo : IAdminRepo
{
    private readonly UserContext _userContext;

    public AdminRepo (UserContext userContext)
    {
        _userContext = userContext;
    }
    public void AddHiringDate(Admin hiringDate)
    {
        _userContext.Set<Admin>().Add(hiringDate);
    }

    public void DeleteHiringDate(Admin hiringDate)
    {
        
        
         _userContext.Set<Admin>().Remove(hiringDate);
        
    }

    public IEnumerable<Admin> GetAllHiringDate()
    {
        return _userContext.Set<Admin>().ToList();
    }


    public int SaveChanges()
    {
        return _userContext.SaveChanges();
    }

    public void UpdateHiringData(Admin admin)
    {
        //
    }

    void IAdminRepo.AddHiringData(Admin hiringDate)
    {
        throw new NotImplementedException();
    }

    void IAdminRepo.DeleteHiringData(Admin hiringDate)
    {
        throw new NotImplementedException();
    }

    IEnumerable<Admin> IAdminRepo.GetAllHiringDate()
    {
        throw new NotImplementedException();
    }

    Admin IAdminRepo.GetHiringDataById(int hiringDateId)
    {
        throw new NotImplementedException();
    }

    int IAdminRepo.SaveChanges()
    {
        throw new NotImplementedException();
    }

    void IAdminRepo.UpdateHiringData(Admin hiringDate)
    {
        throw new NotImplementedException();
    }
}
