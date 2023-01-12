using My_School.Domain.Common;
using My_School.Domain.Entities.Employees;
using My_School.Domain.Enums;

using MySchool.Services.ViewModels.Articles;

namespace MySchool.Services.ViewModels.Employees;

public class EmployeeFullViewModel : BaseEntity
{

	public string Name { get; set; } = string.Empty;

	public string Phone { get; set; } = string.Empty;

	public Role Role { get; set; }

	public List<ArticleShortViewModel> Articles { get; set; } = new();

	public static implicit operator EmployeeFullViewModel(Employee entity)
	{
		return new EmployeeFullViewModel()
		{
			Id = entity.Id,
			Name = entity.Name,
			Phone = entity.Email,
			Role = entity.Role
		};
	}
}
