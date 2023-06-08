using Microsoft.EntityFrameworkCore;

namespace Home_Away.DAL
{
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

        public IEnumerable<Property>? FilterProperty(string? Type, string? region, string? area, string? category, decimal? price_per_night, int? capacity, int? no_of_rooms, int? no_of_bathrooms, int? no_of_floors, decimal? avg_rating)
        {
            return _userContext.Set<Property>().Where(p => p.Type == Type || p.Region == region || p.Area == area || p.Category == category || p.PricePerNight == price_per_night || p.Capacity == capacity || p.NumberOfRooms == no_of_rooms || p.NumberOfBathrooms == no_of_bathrooms || p.NumberOfFloors == no_of_floors || p.AverageRating == avg_rating).ToList();
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
            // TODO: Implement update logic
        }

        public int SaveChanges()
        {
            return _userContext.SaveChanges();
        }

        public void AdminAcceptance(int prop_id)
        {
            var property = _userContext.Set<Property>().Find(prop_id);

            if (property != null)
            {
                property.State = "Accepted";
            }
        }

        public void AdminRefusal(int prop_id)
        {
            var property = _userContext.Set<Property>().Find(prop_id);

            if (property != null)
            {
                property.State = "Refused";
            }
        }

      
    }
}
