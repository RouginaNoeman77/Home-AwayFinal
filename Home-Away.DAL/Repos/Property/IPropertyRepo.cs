namespace Home_Away.DAL;
public interface IPropertyRepo
{
    IEnumerable<Property> GetAllProperties();
    Property? GetPropertyById(int id);
    Property? GetPropertyByOwner(string owner_id);
    Property? GetPropertyByState(string state); 
    Property? GetPropertyByAdmin(string admin_id);
    Property? GetPropertyByImage(int image_id);
    Property FilterProperty(string? title, string? address, string? Type, string? region, string? area, string? category, decimal? price_per_night, int? capacity, int? no_of_rooms, int? no_of_bathrooms, int? no_of_floors , decimal? avg_rating);
    void AddProperty(Property property);
    void UpdateProperty(Property property);
    void DeleteProperty(Property property);
    int SaveChanges();

}
