using My_School.Domain.Common;
using My_School.Domain.Entities.Employees;

namespace MySchool.Services.ViewModels.Employees;

public class EmployeeShortViewModel : BaseEntity
{
	public string Email { get; set; } = string.Empty;
	public string Name { get; set; } = string.Empty;
	public static implicit operator EmployeeShortViewModel(Employee entity)
	{
		return new EmployeeShortViewModel()
		{
			Email = entity.Email,
			Name = entity.Name,
			Id = entity.Id
		};
	}
}
