using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Away.BL.DTOS.Images_Dto;

public class SavingFileOptions
{
	public string Scheme { get; set; }=string.Empty;
	public string BaseUrl { get; set; }= string.Empty;
	public string FolderPath { get; set; } = string.Empty;
}
