using My_School.Domain.Common;
using My_School.Domain.Enums;

namespace My_School.Domain.Entities.Employees;


public class Employee : BaseEntity
{
	public string Name { get; set; } = string.Empty;

	public string Password { get; set; } = string.Empty;

	public string Email { get; set; } = string.Empty;

	public bool EmailVerified { get; set; }

	public Role Role { get; set; } = 0;

	public string Image { get; set; } = string.Empty;

	public DateTime Acted { get; set; }
}
