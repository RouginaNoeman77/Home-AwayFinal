
namespace Home_Away.DAL;
public interface IPropertyRepo
{
    public IEnumerable<Property> GetAllProperties();

    public Property? GetPropertyById(int id);

    public IEnumerable<Property>? GetPropertyByOwner(string owner_id);

    public IEnumerable<Property>? GetPropertyByAdmin(string admin_id);

    public IEnumerable<Property>? GetPropertyByState(string state);

    public IEnumerable<Property>? FilterProperty(string? title, string? address, string? Type, string? region, string? area, string? category, decimal? price_per_night, int? capacity, int? no_of_rooms, int? no_of_bathrooms, int? no_of_floors, decimal? avg_rating);

    public int GetPropertyByImage(int image_id);

    public void AddProperty(Property property);

    public void DeleteProperty(Property property);

    public void UpdateProperty(Property property);

    public int SaveChanges();
}
