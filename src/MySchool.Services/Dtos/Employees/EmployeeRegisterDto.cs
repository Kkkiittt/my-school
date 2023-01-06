using System.ComponentModel.DataAnnotations;

using Microsoft.AspNetCore.Http;

namespace MySchool.Services.Dtos.Employees;

public class EmployeeRegisterDto
{
	[Required] public string Phone { get; set; } = string.Empty;
	[Required] public string Name { get; set; } = string.Empty;
	[Required] public string Password { get; set; } = string.Empty;
	public IFormFile? Image { get; set; }
}
