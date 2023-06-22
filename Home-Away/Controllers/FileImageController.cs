using Home_Away.BL;
using Home_Away.BL.DTOS.Images_Dto;
using Home_Away.BL.Managers.UploadPhoto;
using Microsoft.AspNetCore.Mvc;

namespace Home_Away.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FileImageController : ControllerBase
{
	private readonly IUploadManager _uploadManager;
	private SavingFileOptions options;
	public FileImageController(IUploadManager uploadManager)
	{
		_uploadManager = uploadManager;
		//SetOptions();
	}

	private void SetOptions()
	{
		options = new SavingFileOptions
		{
			BaseUrl = Request.Host.ToString(),
			Scheme = Request.Scheme,
			FolderPath = Path.Combine(Environment.CurrentDirectory, "Images"),
		};
	}

	[HttpPost]
	public ActionResult<UploadFileDto> Upload(IFormFile file)
	{
		SetOptions();
		var url = _uploadManager.uploadImage(file, options);
		return new UploadFileDto(true, "Success", url);
	}
	[HttpPost]
	[Route("multi")]
	public ActionResult<UploadFilesDto> UploadFileArray()
	{
		var files = Request.Form.Files;
		SetOptions();
		var urls = files.Select(f => _uploadManager.uploadImage(f, options))
			.Where(u=>u!="")
			.ToArray();
		
		return new UploadFilesDto(true, "Success", urls);
	}
}
