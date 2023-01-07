
using System.ComponentModel.DataAnnotations;


namespace MySchool.Services.Dtos.Employees;

public class EmployeeLoginDto
{
	[Required, Phone]
	public string Phone { get; set; } = string.Empty;
	[Required, MaxLength(16), MinLength(8)]
	public string Password { get; set; } = string.Empty;
}
