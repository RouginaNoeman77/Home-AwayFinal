
namespace Home_Away.DAL;
        public interface IAdminRepo
    {
        string AddAdmin (Admin admin);
        void UpdateAdmin (Admin admin);
        IEnumerable<Admin> GetAllAdmins();
        Admin? GetAdminById(string id);
        void DeleteAdmin(Admin entity);

        int SaveChanges();

}
