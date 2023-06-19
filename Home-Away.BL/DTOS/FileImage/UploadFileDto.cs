using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Away.BL;

public class UploadFileDto
{
	public bool IsSuccess { get; set; }
	public string Message { get; set; }
	public string Url { get; set; }

    public UploadFileDto(bool isSuccess , string msg , string url="")
    {
        IsSuccess = isSuccess;
        Message = msg;  
        Url = url;
    }
}
