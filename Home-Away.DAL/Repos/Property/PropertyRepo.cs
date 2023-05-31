
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

    public Property? GetPropertyById (int id)
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
        var image = _userContext.Set<Images>().FirstOrDefault(p => p.Id == image_id);
        return image.PropertyId;
    }
    public IEnumerable<Property>? GetPropertyByState(string state)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Property>? FilterProperty(string? title, string? address, string? Type, string? region, string? area, string? category, decimal? price_per_night, int? capacity, int? no_of_rooms, int? no_of_bathrooms, int? no_of_floors, decimal? avg_rating)
    {
        throw new NotImplementedException();
    }

    public void AddProperty(Property property)
    {
        throw new NotImplementedException();
    }

    public void DeleteProperty(Property property)
    {
        throw new NotImplementedException();
    }

    public void UpdateProperty(Property property)
    {
        
    }

    public int SaveChanges()
    {
        return _userContext.SaveChanges();
    }

}
