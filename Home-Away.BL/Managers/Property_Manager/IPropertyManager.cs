using Home_Away.BL.Dtos.Property_Dto;


namespace Home_Away.BL.Managers.Property_Manager;

public interface IPropertyManager
{
    public List<PropertyReadDto> GetAllProperties();

    public PropertyReadDto GetPropertyById(int id);

    public List<PropertyReadDto> GetPropertyByOwnerId(string ownerId);

    public List<PropertyReadDto> GetPropertyByAdminId(string adminId);

    public List<PropertyReadDto> GetPropertyByState(string state);

    public List<PropertyFilterDto> FilterProperty(string? Type, string? region, string? area, string? category, decimal? price_per_night, int? capacity, int? no_of_rooms, int? no_of_bathrooms, int? no_of_floors, decimal? avg_rating);

    public int GetPropertyByImage(int image_id);

    public int AddProperty(PropertyAddDto propertyDto);

    public bool UpdateProperty(PropertyUpdateDto propertyDto);

    bool DeleteProperty(int id);

    void AdminAcceptance(int id);

    void AdminRefusal(int id);
}
