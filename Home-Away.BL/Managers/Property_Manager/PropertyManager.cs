using Home_Away.BL.Dtos.Property_Dto;
using Home_Away.DAL;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Property = Home_Away.DAL.Property;


namespace Home_Away.BL.Managers.Property_Manager
{
    public class PropertyManager : IPropertyManager
    {
        private readonly IPropertyRepo _propertyRepo;
        private readonly IImagesRepo _imagesRepo;
        private readonly IReviewsRepo _reviewsRepo;
        public PropertyManager(IPropertyRepo propertyRepo, IImagesRepo imagesRepo, IReviewsRepo reviewsRepo)
        {
            _propertyRepo = propertyRepo;
            _imagesRepo = imagesRepo;
            _reviewsRepo = reviewsRepo;

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
                AdminId = p.AdminId,
                Prop_Images = p.Prop_Images,
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
                AdminId = property.AdminId,
                Prop_Images = property.Prop_Images,
                Reviews = property.Prop_Reviews,
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
                AdminId = p.AdminId,
                Prop_Images = p.Prop_Images,
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
                AdminId = p.AdminId,
                Prop_Images = p.Prop_Images

            }).ToList();
        }

        public List<PropertyFilterDto> FilterProperty( string? type, string? region, string? area, string? category, decimal? price_per_night, int? capacity, int? no_of_rooms, int? no_of_bathrooms, int? no_of_floors, decimal? avg_rating)
        {
            var properties = _propertyRepo.FilterProperty(type, region, area, category, price_per_night, capacity, no_of_rooms, no_of_bathrooms, no_of_floors, avg_rating);

            if (properties is null)
            {
                return null;
            }

            return properties.Select(p => new PropertyFilterDto
            {
               
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
                OwnerId = propertyDto.OwnerId,
                AdminId = propertyDto.AdminId,

                Prop_Images = propertyDto.Prop_Images.Select(i => new Images {Url=i}).ToList()

            };

            _propertyRepo.AddProperty(property);
            _propertyRepo.SaveChanges();
            //int propId = property.Id;
            //List<Images> propImages = propertyDto.Prop_Images;
            //foreach (var image in propImages)
            //{
            //    image.PropertyId = propId;
            //}
            //property.Prop_Images = propImages;
            //_propertyRepo.SaveChanges();
            return property.Id;
        }

        public bool UpdateProperty(PropertyUpdateDto propertyDto, string? userid)
        {
            var propertyFromDb = _propertyRepo.GetPropertyById(propertyDto.Id);

            if (propertyFromDb is null)
            {
                return false;
            }
            if(userid != propertyFromDb.OwnerId) { return false; }

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

        public bool DeleteProperty(int id)
        {
            var propertyFromDb = _propertyRepo.GetPropertyById(id);

            if (propertyFromDb is null)
            {
                return false;
            }

            _propertyRepo.DeleteProperty(propertyFromDb);
            _propertyRepo.SaveChanges();
            return true;
        }

        public void AdminAcceptance(int id)
        {
            _propertyRepo.AdminAcceptance(id);
            _propertyRepo.SaveChanges();
        }

        public void AdminRefusal(int id)
        {
            _propertyRepo.AdminRefusal(id);
            _propertyRepo.SaveChanges();
        }
    }
}
