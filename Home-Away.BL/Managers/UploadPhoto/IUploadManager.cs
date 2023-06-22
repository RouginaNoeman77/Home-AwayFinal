using Home_Away.BL.DTOS.Images_Dto;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Away.BL.Managers.UploadPhoto;

public interface IUploadManager
{
	public string uploadImage(IFormFile file, SavingFileOptions options);
}
