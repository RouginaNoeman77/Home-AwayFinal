using Home_Away.BL.Dtos.Property_Dto;
using Home_Away.BL.Managers.Property_Manager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Home_Away.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyController : ControllerBase
    {
        private readonly IPropertyManager _PropertyManager;

        public PropertyController(IPropertyManager propertyManager)
        {
            _PropertyManager = propertyManager;
        }

        [HttpGet]
        public ActionResult<List<PropertyReadDto>> GetAllProperties()
        {
            return _PropertyManager.GetAllProperties();
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<PropertyReadDto> GetPropertyById(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var property = _PropertyManager.GetPropertyById(id);

            if (property is null)
            {
                return BadRequest();
            }

            return property;
        }

        [HttpGet]
        [Route("api/GetPropertyByOwnerId/{id}")]
        public ActionResult<List<PropertyReadDto>> GetPropertyByOwnerId(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var properties = _PropertyManager.GetPropertyByOwnerId(id);

            if (properties is null)
            {
                return BadRequest();
            }

            return properties;
        }

        [HttpGet]
        [Route("api/GetPropertyByAdminId/{id}")]
        public ActionResult<List<PropertyReadDto>> GetPropertyByAdminId(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var properties = _PropertyManager.GetPropertyByAdminId(id);

            if (properties is null)
            {
                return BadRequest();
            }

            return properties;
        }

        [HttpGet]
        [Route("api/GetPropertyByState/{state}")]
        public ActionResult<List<PropertyReadDto>> GetPropertyByState(string state)
        {
            if (state == null)
            {
                return NotFound();
            }
            var properties = _PropertyManager.GetPropertyByState(state);

            if (properties is null)
            {
                return BadRequest();
            }

            return properties;
        }

        [HttpGet]
        [Route("Acceptance/{id}")]
        public ActionResult AdminAcceptance(int propId)
        {
            _PropertyManager.AdminAcceptance(propId);
            return Ok(new GenerateMessage("Property Accepted"));
        }

        [HttpGet]
        [Route("Refusal/{id}")]
        public ActionResult AdminRefusal(int propId)
        {
            _PropertyManager.AdminRefusal(propId);
            return Ok(new GenerateMessage("Property Refused"));
        }

        [HttpGet]
        [Route("api/FilterProperty")] 
        public ActionResult<List<PropertyFilterDto>> GetPropertyFilter(string? Type, string? region, string? area, string? category, decimal? price_per_night, int? capacity, int? no_of_rooms, int? no_of_bathrooms, int? no_of_floors, decimal? avg_rating)
        {
            var Properties = _PropertyManager.FilterProperty(Type, region, area, category, price_per_night, capacity, no_of_rooms, no_of_bathrooms, no_of_floors, avg_rating).ToList();

            if (Properties is null)
            {
                return BadRequest();
            }

            return Properties;
        }

        [HttpGet]
        [Route("api/GetPropertyByImageId/{id}")]
        public ActionResult<int> GetPropertyByImageId(int imageId)
        {
           int property = _PropertyManager.GetPropertyByImage(imageId);

            return property;
        }

        [HttpPost]
        public ActionResult AddProperty (PropertyAddDto property)
        {
            var newProperty = _PropertyManager.AddProperty(property);

            return CreatedAtAction("GetPropertyById", new { id = newProperty }, new GenerateMessage("Property Added Successfully"));
        }

        [HttpPut]
        public ActionResult UpdateProperty(PropertyUpdateDto property)
        {
            var IsFound = _PropertyManager.UpdateProperty(property);

            if (!IsFound)
            {
                return NotFound();
            }
            return NoContent();
        }

        [HttpDelete]
        public ActionResult DeleteProperty(int propertyId)
        {
            var IsFound = _PropertyManager.DeleteProperty(propertyId) ;

            if (!IsFound)
            {
                return NotFound(new GenerateMessage("Property Not Found"));
            }
            return Ok(new GenerateMessage("Property Deleted Successfully"));
        }

       
    }
}
