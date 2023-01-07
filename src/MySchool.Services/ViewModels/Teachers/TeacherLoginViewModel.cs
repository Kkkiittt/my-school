using My_School.Domain.Models.Common;

namespace MySchool.Services.ViewModels.Teachers;

public class TeacherLoginViewModel : BaseEntity
{
	public int Code { get; set; }

	public string Token { get; set; } = string.Empty;
}
