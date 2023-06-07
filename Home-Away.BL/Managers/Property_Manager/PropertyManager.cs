using Home_Away.BL.Dtos.Property_Dto;
using Home_Away.DAL;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;

namespace Home_Away.BL.Managers.Property_Manager
{
    public class PropertyManager : IPropertyManager
    {
        private readonly IPropertyRepo _propertyRepo;

        public PropertyManager(IPropertyRepo propertyRepo)
        {
            _propertyRepo = propertyRepo;
        }

        public List<PropertyReadDto> GetAllProperties()
        {
            var propertiesFromDb = _propertyRepo.GetAllProperties();

            return propertiesFromDb.Select(p => new PropertyReadDto
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
                AverageRating = p.AverageRating,
                OwnerId = p.OwnerId,
                AdminId = p.AdminId
            }).ToList();
        }

        public PropertyReadDto GetPropertyById(int id)
        {
            var property = _propertyRepo.GetPropertyById(id);

            if (property is null)
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
                AverageRating = property.AverageRating,
                OwnerId = property.OwnerId,
                AdminId = property.AdminId
            };
        }

        public List<PropertyReadDto> GetPropertyByOwnerId(string ownerId)
        {
            var properties = _propertyRepo.GetPropertyByOwner(ownerId);

            if (properties is null)
            {
                return null;
            }

            return properties.Select(p => new PropertyReadDto
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
                AverageRating = p.AverageRating,
                OwnerId = p.OwnerId,
                AdminId = p.AdminId
            }).ToList();
        }

        public List<PropertyReadDto> GetPropertyByAdminId(string adminId)
        {
            var properties = _propertyRepo.GetPropertyByAdmin(adminId);

            if (properties is null)
            {
                return null;
            }

            return properties.Select(p => new PropertyReadDto
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
            var properties = _propertyRepo.GetPropertyByState(state);

            if (properties is null)
            {
                return null;
            }

            return properties.Select(p => new PropertyReadDto
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
                AverageRating = p.AverageRating,
                OwnerId = p.OwnerId,
                AdminId = p.AdminId
            }).ToList();
        }

        public List<PropertyFilterDto> FilterProperty(string? title, string? type, string? region, string? area, string? category, decimal? price_per_night, int? capacity, int? no_of_rooms, int? no_of_bathrooms, int? no_of_floors, decimal? avg_rating)
        {
            var properties = _propertyRepo.FilterProperty(title, type, region, area, category, price_per_night, capacity, no_of_rooms, no_of_bathrooms, no_of_floors, avg_rating);

            if (properties is null)
            {
                return null;
            }

            return properties.Select(p => new PropertyFilterDto
            {
                Title = p.Title,
                Type = p.Type,
                Region = p.Region,
                Area = p.Area,
                Category = p.Category,
                PricePerNight = p.PricePerNight,
                Capacity = p.Capacity,
                NumberOfRooms = p.NumberOfRooms,
                NumberOfBathrooms = p.NumberOfBathrooms,
                NumberOfFloors = p.NumberOfFloors,
                AverageRating = p.AverageRating
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
                AverageRating = propertyDto.AverageRating,
                OwnerId = propertyDto.OwnerId
            };

            _propertyRepo.AddProperty(property);
            _propertyRepo.SaveChanges();
            return property.Id;
        }

        public bool UpdateProperty(PropertyUpdateDto propertyDto)
        {
            var propertyFromDb = _propertyRepo.GetPropertyById(propertyDto.Id);

            if (propertyFromDb is null)
            {
                return false;
            }

            propertyFromDb.Title = propertyDto.Title;
            propertyFromDb.Description = propertyDto.Description;
            propertyFromDb.Address = propertyDto.Address;
            propertyFromDb.Type = propertyDto.Type;
            propertyFromDb.Region = propertyDto.Region;
            propertyFromDb.Area = propertyDto.Area;
            propertyFromDb.Category = propertyDto.Category;
            propertyFromDb.PricePerNight = propertyDto.PricePerNight;
            propertyFromDb.Capacity = propertyDto.Capacity;
            propertyFromDb.NumberOfRooms = propertyDto.NumberOfRooms;
            propertyFromDb.NumberOfFloors = propertyDto.NumberOfFloors;
            propertyFromDb.NumberOfBathrooms = propertyDto.NumberOfBathrooms;
            propertyFromDb.State = propertyDto.State;

            _propertyRepo.UpdateProperty(propertyFromDb);
            _propertyRepo.SaveChanges();
            return true;
        }

        public void DeleteProperty(int id)
        {
            var propertyFromDb = _propertyRepo.GetPropertyById(id);

            if (propertyFromDb is null)
            {
                return;
            }

            _propertyRepo.DeleteProperty(propertyFromDb);
            _propertyRepo.SaveChanges();
        }
    }
}
