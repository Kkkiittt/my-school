using My_School.Domain.Enums;
using My_School.Domain.Models.Common;

namespace My_School.Domain.Models.Employees;


public class Employee : BaseEntity
{
	public string Name { get; set; } = String.Empty;

	public string Password { get; set; } = String.Empty;

	public string Phone { get; set; } = String.Empty;

	public bool PhoneVerified { get; set; }

	public Role Role { get; set; } = 0;

	public string Image { get; set; } = string.Empty;

	public DateTime Acted { get; set; }
}
