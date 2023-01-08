using System.ComponentModel.DataAnnotations;

using Microsoft.AspNetCore.Http;

using My_School.Domain.Enums;
using My_School.Domain.Models.Employees;

namespace MySchool.Services.Dtos.Employees;

public class EmployeeRegisterDto
{
	[Required, Phone] public string Phone { get; set; } = string.Empty;
	[Required] public string Name { get; set; } = string.Empty;
	[Required] public string Password { get; set; } = string.Empty;
	public IFormFile? Image { get; set; }
	public static implicit operator Employee(EmployeeRegisterDto dto)
	{
		return new Employee()
		{
			Phone = dto.Phone,
			Name = dto.Name,
			Acted = DateTime.MinValue,
			PhoneVerified = false,
			Role = Role.Teacher
		};
	}
}
