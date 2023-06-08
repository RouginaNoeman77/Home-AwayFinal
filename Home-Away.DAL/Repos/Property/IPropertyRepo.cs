

namespace Home_Away.DAL;

public interface IPropertyRepo
{
    public IEnumerable<Property> GetAllProperties();

    public Property? GetPropertyById(int id);

    public IEnumerable<Property>? GetPropertyByOwner(string owner_id);

    public IEnumerable<Property>? GetPropertyByAdmin(string admin_id);

    public IEnumerable<Property>? GetPropertyByState(string state);


    IEnumerable<Property>? FilterProperty( string? Type, string? region, string? area, string? category, decimal? price_per_night, int? capacity, int? no_of_rooms, int? no_of_bathrooms, int? no_of_floors, decimal? avg_rating);

    int GetPropertyByImage(int image_id);

    void AdminAcceptance(int prop_id);

    void AdminRefusal(int prop_id);

    void AddProperty(Property property);

    void DeleteProperty(Property property);

    void UpdateProperty(Property property);

    int SaveChanges();
}

