using Azure.Core;
using Home_Away.BL.DTOS.Images_Dto;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Away.BL.Managers.UploadPhoto;

public class UploadImage:IUploadManager
{
	public string uploadImage (IFormFile file, SavingFileOptions options)
	{
		var extension = Path.GetExtension(file.FileName);
		var allowedExtensions = new string[]
		{
			".png",
			".jpg",
			".svg",
			".jpeg",
		};

		bool isExtensionAllowed = allowedExtensions.Contains(extension, StringComparer.InvariantCultureIgnoreCase);

		if (!isExtensionAllowed)
		{
			return "";
		}

		bool isSizeAllowed = file.Length is > 0 and <= 4_000_000;
		if (!isSizeAllowed)
		{
			return "";
		}

		var newFileName = $"{Guid.NewGuid()}{extension}";
		var fullFilePath = Path.Combine(options.FolderPath, newFileName);

		using var stream = new FileStream(fullFilePath, FileMode.Create);
		file.CopyTo(stream);
		var url = $"{options.Scheme}://{options.BaseUrl}/Images/{newFileName}";
		return url;
	}
}
