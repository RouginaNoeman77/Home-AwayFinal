using Home_Away.BL.Dtos.Images_Dto;
using Home_Away.BL.Managers.Images_Manager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace Home_Away.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly IImagesManager _imagesManager;

        public ImagesController(IImagesManager imagesManager)
        {
            _imagesManager = imagesManager;
        }

        [HttpGet]
        public ActionResult<List<ImagesReadDto>> GetAllImages()
        {
            return _imagesManager.GetAllImages().ToList();
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<ImagesReadDto?> GetImageById(int id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var image = _imagesManager.GetImagesById(id);

            if (image is null)
            {
                return NotFound();
            }

            return image;
        }

        [HttpGet]
        [Route("GetImagesByPropertyId/{id}")]
        public ActionResult<List<ImagesReadDto?>>GetImagesByPropertyId(int id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var images = _imagesManager.GetImagesByPropertyId(id);

            if(images is null)
            {
                return NotFound() ;
            }
            return images; 
        } 

        [HttpPost]
        public ActionResult AddImage(AddImagesDto image) 
        { 
            var new_Image = _imagesManager.Add(image);

            return CreatedAtAction("GetImageById", new { id = new_Image }, new GenerateMessage("Image Added Successfully"));
        }

        [HttpPut]
        public ActionResult UpdateImage(ImagesReadDto image)
        {
            var IsFound = _imagesManager.GetImagesById(image.Id);

            if(IsFound is null)
            {
                return NotFound(new GenerateMessage("Image Not Found"));
            }
            _imagesManager.update(image);
            return Ok(new GenerateMessage("Image Updated Successfully"));
        }

        [HttpDelete]
        public ActionResult DeleteImage(int id)
        {
            var IsFound = _imagesManager.delete(id);

            if (!IsFound)
            {
                return NotFound(new GenerateMessage("Image Not Found"));
            }
            
            return Ok(new GenerateMessage("Image Deleted Successfully"));
        }
    } 
}
