﻿
using System.ComponentModel.DataAnnotations;


namespace MySchool.Services.Dtos.Common;

public class PhoneConfirmDto
{
	[Required]
	public int Id{ get; set; }
	[Required]
	public int Code{ get; set; }
}