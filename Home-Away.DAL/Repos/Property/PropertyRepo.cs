using Microsoft.EntityFrameworkCore;

namespace Home_Away.DAL;
public class PropertyRepo : IPropertyRepo
{
    private readonly UserContext _userContext;
    public PropertyRepo(UserContext userContext)
    {
        _userContext = userContext;
    }

    public IEnumerable<Property> GetAllProperties()
    {
        return _userContext.Set<Property>().AsNoTracking();
    }

    public Property? GetPropertyById(int id)
    {
        return _userContext.Set<Property>().Find(id);
    }

    public IEnumerable<Property>? GetPropertyByOwner(string owner_id)
    {
        return _userContext.Set<Property>().Where(o => o.OwnerId == owner_id);
    }
    public IEnumerable<Property>? GetPropertyByAdmin(string admin_id)
    {
        return _userContext.Set<Property>().Where(o => o.AdminId == admin_id);
    }

    public int GetPropertyByImage(int image_id)
    {
        var Image = _userContext.Set<Images>().Find(image_id);

        return Image.PropertyId;
    }

    public IEnumerable<Property>? GetPropertyByState(string state)
    {
        return _userContext.Set<Property>().Where(s => s.State == state);
    }

    public IEnumerable<Property>? FilterProperty(string? title, string? address, string? Type, string? region, string? area, string? category, decimal? price_per_night, int? capacity, int? no_of_rooms, int? no_of_bathrooms, int? no_of_floors, decimal? avg_rating)
    {
        var query = _userContext.Set<Property>().AsQueryable();

        if (!string.IsNullOrEmpty(title))
            query = query.Where(p => p.Title.Contains(title));

        if (!string.IsNullOrEmpty(address))
            query = query.Where(p => p.Address.Contains(address));

        if (!string.IsNullOrEmpty(region))
            query = query.Where(p => p.Region == region);

        if (!string.IsNullOrEmpty(area))
            query = query.Where(p => p.Area == area);

        if (!string.IsNullOrEmpty(category))
            query = query.Where(p => p.Category == category);

        if (price_per_night.HasValue)
            query = query.Where(p => p.PricePerNight == price_per_night.Value);

        if (capacity.HasValue)
            query = query.Where(p => p.Capacity == capacity.Value);

        if (no_of_rooms.HasValue)
            query = query.Where(p => p.NumberOfRooms == no_of_rooms.Value);

        if (no_of_bathrooms.HasValue)
            query = query.Where(p => p.NumberOfBathrooms == no_of_bathrooms.Value);

        if (no_of_floors.HasValue)
            query = query.Where(p => p.NumberOfFloors == no_of_floors.Value);

        if (avg_rating.HasValue)
            query = query.Where(p => p.AverageRating == avg_rating.Value);

        return query.ToList();
    }

    public void AddProperty(Property property)
    {
        _userContext.Add(property);
    }

    public void DeleteProperty(Property property)
    {
        _userContext.Remove(property);
    }

    public void UpdateProperty(Property property)
    {
        
    }

    public int SaveChanges()
    {
        return _userContext.SaveChanges();
    }

  
}
