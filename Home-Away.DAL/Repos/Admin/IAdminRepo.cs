
namespace Home_Away.DAL;
public interface IAdminRepo
{
    IEnumerable<Admin> GetAllHiringDate();
    Admin GetHiringDataById(int hiringDateId);
    void AddHiringData(Admin hiringDate);
    void UpdateHiringData(Admin hiringDate);
    void DeleteHiringData(Admin hiringDate);
    int SaveChanges();
}
