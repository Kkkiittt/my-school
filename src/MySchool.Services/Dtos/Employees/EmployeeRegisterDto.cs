using System.ComponentModel.DataAnnotations;

using Microsoft.AspNetCore.Http;

using My_School.Domain.Entities.Employees;
using My_School.Domain.Enums;

namespace MySchool.Services.Dtos.Employees;

public class EmployeeRegisterDto
{
	[Required, EmailAddress] public string Email { get; set; } = string.Empty;
	[Required] public string Name { get; set; } = string.Empty;
	[Required] public string Password { get; set; } = string.Empty;
	public IFormFile? Image { get; set; }
	public static implicit operator Employee(EmployeeRegisterDto dto)
	{
		return new Employee()
		{
			Email = dto.Email,
			Name = dto.Name,
			Acted = DateTime.MinValue,
			EmailVerified = false,
			Role = Role.Teacher
		};
	}
}
