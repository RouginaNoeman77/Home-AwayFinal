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
            IQueryable<Property> query = _userContext.Set<Property>();

            if (Type != null)
            {
                query = query.Where(x => x.Type == Type);
            }

            if (region != null)
            {
                query = query.Where(x => x.Region == region);
            }

            if (area != null)
            {
                query = query.Where(x => x.Area == area);
            }

            if (category != null)
            {
                query = query.Where(x => x.Category == category);
            }


            if(price_per_night != null) 
            { 
                query = query.Where(x => x.PricePerNight <= price_per_night);

            }

            if (capacity != null)
            {
                query = query.Where(x => x.Capacity <= capacity);
            }

            if (no_of_rooms != null)
            {
                query = query.Where(x => x.NumberOfRooms == no_of_rooms);
            }

            if (no_of_floors != null)
            {
                query = query.Where(x => x.NumberOfFloors == no_of_floors);
            }

            if (no_of_bathrooms != null)
            {
                query = query.Where(x => x.NumberOfBathrooms == no_of_bathrooms);
            }

            if (avg_rating != null)
            {
                query = query.Where(x => x.AverageRating == avg_rating);
            }

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
