using Home_Away.BL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Home_Away.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FileImageController : ControllerBase
{
	[HttpPost]
	public ActionResult<UploadFileDto> Upload(IFormFile file)
	{
		var extension = Path.GetExtension(file.FileName);
		var allowedExtensions = new string[]
		{
			".png",
			".jpg",
			".svg",
			".jpeg",
		};

		bool isExtensionAllowed = allowedExtensions.Contains(extension,StringComparer.InvariantCultureIgnoreCase);

		if(!isExtensionAllowed) 
		{
			return BadRequest(new UploadFileDto(false, "Extension Is Not Valid"));
		}

		bool isSizeAllowed = file.Length is > 0 and <= 4_000_000;
		if(!isSizeAllowed) 
		{
			return BadRequest(new UploadFileDto(false, "Size Is Not Valid"));
		}

		var newFileName = $"{Guid.NewGuid()}{extension}";
		var imagesPath = Path.Combine(Environment.CurrentDirectory,"Images");
		var fullFilePath = Path.Combine(imagesPath,newFileName);

		using var stream = new FileStream(fullFilePath, FileMode.Create);
		file.CopyTo(stream);

		var url = $"{Request.Scheme}://{Request.Host}/Images/{newFileName}";
		return new UploadFileDto(true, "Success", url);
	}
}
