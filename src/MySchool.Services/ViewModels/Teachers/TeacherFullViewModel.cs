
using My_School.Domain.Enums;
using My_School.Domain.Models.Common;

using MySchool.Services.ViewModels.Articles;

namespace MySchool.Services.ViewModels.Teachers;

public class TeacherFullViewModel : BaseEntity
{

	public string Name { get; set; } = string.Empty;

	public string Phone { get; set; } = string.Empty;

	public Role Role { get; set; }

	public List<ArticleShortViewModel> Articles { get; set; } = new();
}
