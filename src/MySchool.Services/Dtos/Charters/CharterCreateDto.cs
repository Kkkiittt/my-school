using System.ComponentModel.DataAnnotations;

using Microsoft.AspNetCore.Http;

namespace MySchool.Services.Dtos.Charters;

public class CharterCreateDto
{
	public IFormFile? Image{ get; set; }
	[Required]
	public int StudentId{ get; set; }
}
