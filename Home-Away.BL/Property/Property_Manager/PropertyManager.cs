using Home_Away.DAL;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace Home_Away.BL;
public class PropertyManager : IPropertyManager
{
    private readonly IPropertyRepo _propertyRepo;

    public PropertyManager(IPropertyRepo propertyRepo)
    {
        _propertyRepo = propertyRepo;
    }

    public List<PropertyReadDto> GetAllProperties()
    {
        var PropertiesFromDb = _propertyRepo.GetAllProperties();

        return PropertiesFromDb.Select(p => new PropertyReadDto
        { 
            Id = p.Id,
            Title= p.Title,
            Description= p.Description,
            Address= p.Address,
            Type= p.Type,
            Region= p.Region,
            Area= p.Area,
            Category = p.Category,
            PricePerNight= p.PricePerNight,
            Capacity= p.Capacity,
            NumberOfRooms= p.NumberOfRooms,
            NumberOfBathrooms= p.NumberOfBathrooms,
            NumberOfFloors= p.NumberOfFloors,
            DateOfAddingProperty= p.DateOfAddingProperty,
            State= p.State,
            AverageRating=p.AverageRating,
            OwnerId= p.OwnerId,
            AdminId= p.AdminId
        }).ToList();
    }

    public PropertyReadDto GetPropertyById(int id)
    {
        var property = _propertyRepo.GetPropertyById(id);

        if(property is null)
        {
            return null;
        }

        return new PropertyReadDto
        {
            Id = property.Id,
            Title = property.Title,
            Description = property.Description,
            Address = property.Address,
            Type = property.Type,
            Region = property.Region,
            Area = property.Area,
            Category = property.Category,
            PricePerNight = property.PricePerNight,
            Capacity = property.Capacity,
            NumberOfRooms = property.NumberOfRooms,
            NumberOfBathrooms = property.NumberOfBathrooms,
            NumberOfFloors = property.NumberOfFloors,
            DateOfAddingProperty = property.DateOfAddingProperty,
            State = property.State,
            AverageRating = property.AverageRating,
            OwnerId = property.OwnerId,
            AdminId = property.AdminId
        };
    }

    public List<PropertyReadDto> GetPropertyByOwnerId(string ownerId)
    {
        var Property = _propertyRepo.GetPropertyByOwner(ownerId);

        if(Property is null)
        {
            return null;
        }

        return Property.Select(p => new PropertyReadDto
        {
            Id = p.Id,
            Title = p.Title,
            Description = p.Description,
            Address = p.Address,
            Type = p.Type,
            Region = p.Region,
            Area = p.Area,
            Category = p.Category,
            PricePerNight = p.PricePerNight,
            Capacity = p.Capacity,
            NumberOfRooms = p.NumberOfRooms,
            NumberOfBathrooms = p.NumberOfBathrooms,
            NumberOfFloors = p.NumberOfFloors,
            DateOfAddingProperty = p.DateOfAddingProperty,
            State = p.State,
            AverageRating = p.AverageRating,
            OwnerId = p.OwnerId,
            AdminId = p.AdminId

        }).ToList();
    }

    public List<PropertyReadDto> GetPropertyByAdminId(string adminId)
    {
        var property = _propertyRepo.GetPropertyByAdmin(adminId);

        if(property is null)
        {
            return null;
        }

        return property.Select(p => new PropertyReadDto
        {
            Id = p.Id,
            Title = p.Title,
            Description = p.Description,
            Address = p.Address,
            Type = p.Type,
            Region = p.Region,
            Area = p.Area,
            Category = p.Category,
            PricePerNight = p.PricePerNight,
            Capacity = p.Capacity,
            NumberOfRooms = p.NumberOfRooms,
            NumberOfBathrooms = p.NumberOfBathrooms,
            NumberOfFloors = p.NumberOfFloors,
            DateOfAddingProperty = p.DateOfAddingProperty,
            State = p.State,
            AverageRating = p.AverageRating,
            OwnerId = p.OwnerId,
            AdminId = p.AdminId

        }).ToList();

    }

    public int GetPropertyByImage(int image_id)
    {
        int property_id = _propertyRepo.GetPropertyByImage(image_id);

        return property_id;
    }

    public List<PropertyReadDto> GetPropertyByState(string state)
    {
        var property = _propertyRepo.GetPropertyByState(state);

        if(property is null)
        {
            return null;
        }

        return property.Select(p => new PropertyReadDto
        {
            Id = p.Id,
            Title = p.Title,
            Description = p.Description,
            Address = p.Address,
            Type = p.Type,
            Region = p.Region,
            Area = p.Area,
            Category = p.Category,
            PricePerNight = p.PricePerNight,
            Capacity = p.Capacity,
            NumberOfRooms = p.NumberOfRooms,
            NumberOfBathrooms = p.NumberOfBathrooms,
            NumberOfFloors = p.NumberOfFloors,
            DateOfAddingProperty = p.DateOfAddingProperty,
            State = p.State,
            AverageRating = p.AverageRating,
            OwnerId = p.OwnerId,
            AdminId = p.AdminId

        }).ToList();


    }

    public List<PropertyFilterDto> FilterProperty(string? title, string? Type, string? region, string? area, string? category, decimal? price_per_night, int? capacity, int? no_of_rooms, int? no_of_bathrooms, int? no_of_floors, decimal? avg_rating)
    {
        var PropertyByFilter = _propertyRepo.FilterProperty(title, Type, region, area,category, price_per_night, capacity, no_of_rooms, no_of_bathrooms, no_of_floors, avg_rating);
        if(PropertyByFilter is null)
        {
            return null;
        }
        return PropertyByFilter.Select(p=> new PropertyFilterDto
        {
            Title = p.Title,
            Type = p.Type,
            Region = p.Region,
            Area = p.Area,
            Category = p.Category,
            PricePerNight = p.PricePerNight,
            Capacity = p.Capacity,
            NumberOfRooms = p.NumberOfRooms,
            NumberOfBathrooms= p.NumberOfBathrooms,
            NumberOfFloors= p.NumberOfFloors,
            AverageRating= p.AverageRating

        }).ToList();
    }
    public int AddProperty(PropertyAddDto propertyDto)
    {
        var property = new Property
        {
            Title = propertyDto.Title,
            Description = propertyDto.Description,
            Address = propertyDto.Address,
            Type = propertyDto.Type,
            Region = propertyDto.Region,
            Area = propertyDto.Area,
            Category = propertyDto.Category,
            PricePerNight = propertyDto.PricePerNight,
            Capacity = propertyDto.Capacity,
            NumberOfRooms = propertyDto.NumberOfRooms,
            NumberOfBathrooms = propertyDto.NumberOfBathrooms,
            NumberOfFloors = propertyDto.NumberOfFloors,
            DateOfAddingProperty = propertyDto.DateOfAddingProperty,
            State = propertyDto.State,
            AverageRating = propertyDto.AverageRating,
        };
        _propertyRepo.AddProperty(property);
        _propertyRepo.SaveChanges();
        return property.Id;
    }

    public bool UpdateProperty(PropertyUpdateDto propertyDto)
    {
        var PropertyFromDb = _propertyRepo.GetPropertyById(propertyDto.Id);

        if(PropertyFromDb is null)
        {
            return false;
        }

        PropertyFromDb.Title = propertyDto.Title;
        PropertyFromDb.Description = propertyDto.Description;
        PropertyFromDb.Address = propertyDto.Address;
        PropertyFromDb.Type = propertyDto.Type;
        PropertyFromDb.Region = propertyDto.Region;
        PropertyFromDb.Area = propertyDto.Area;
        PropertyFromDb.Category = propertyDto.Category;
        PropertyFromDb.PricePerNight = propertyDto.PricePerNight;
        PropertyFromDb.Capacity = propertyDto.Capacity;
        PropertyFromDb.NumberOfRooms = propertyDto.NumberOfRooms;
        PropertyFromDb.NumberOfFloors = propertyDto.NumberOfFloors;
        PropertyFromDb.NumberOfBathrooms = propertyDto.NumberOfBathrooms;

        _propertyRepo.UpdateProperty(PropertyFromDb);
        _propertyRepo.SaveChanges();
        return true;

    }

    public void DeleteProperty(int id)
    {
        var PropertyFromDb = _propertyRepo.GetPropertyById(id);

        if(PropertyFromDb is null) 
        { 
            return; 
        }
        _propertyRepo.DeleteProperty(PropertyFromDb);
        _propertyRepo.SaveChanges();
    }

   
}
