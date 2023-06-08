
namespace Home_Away.DAL;
public interface IAdminRepo
{
    IEnumerable<Admin> GetAllHiringDate();
    void AddHiringDate(Admin hiringDate);
    void UpdateHiringDate(Admin hiringDate);
    void DeleteHiringDate(Admin hiringDate);
    int SaveChanges();
}
