namespace Home_Away.BL;
public interface IPropertyManager
{
    public List<PropertyReadDto> GetAllProperties();

    public PropertyReadDto GetPropertyById(int id);

    public List<PropertyReadDto> GetPropertyByOwnerId(string ownerId);

    public List<PropertyReadDto> GetPropertyByAdminId(string adminId);

    public List<PropertyReadDto> GetPropertyByState(string state);

    public List<PropertyFilterDto> FilterProperty(string? title, string? Type, string? region, string? area, string? category, decimal? price_per_night, int? capacity, int? no_of_rooms, int? no_of_bathrooms, int? no_of_floors, decimal? avg_rating);

    public int GetPropertyByImage(int image_id);

    public int AddProperty(PropertyAddDto propertyDto);

    public bool UpdateProperty(PropertyUpdateDto propertyDto);

    void DeleteProperty(int id);
}
