
using My_School.Domain.Entities.Students;
using My_School.Domain.Enums;
using My_School.Domain.Models.Common;
using My_School.Domain.Models.Employees;
using MySchool.Services.ViewModels.Articles;
using MySchool.Services.ViewModels.Students;

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
			Name = entity.Name,
			Phone = entity.Phone,
			Role = entity.Role
		};
	}
}
