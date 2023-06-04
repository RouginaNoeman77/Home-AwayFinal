﻿
namespace Home_Away.DAL;
    public class PropertyRepo
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

    public IEnumerable<Property>? FilterProperty(string? title, string? Type, string? region, string? area, string? category, decimal? price_per_night, int? capacity, int? no_of_rooms, int? no_of_bathrooms, int? no_of_floors, decimal? avg_rating)
    {
       
     return _userContext.Set<Property>().Where(p => p.Title == title || p.Region == region || p.Area == area || p.Category == category || p.PricePerNight <= price_per_night || p.Capacity == capacity || p.NumberOfRooms == no_of_rooms || p.NumberOfBathrooms == no_of_bathrooms || p.NumberOfFloors == no_of_floors || p.AverageRating == avg_rating).ToList();
      
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
