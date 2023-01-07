using My_School.Domain.Models.Common;

namespace MySchool.Services.ViewModels.Teachers;

public class TeacherSignViewModel : BaseEntity
{
	public int Code { get; set; }

	public string Message { get; set; } = string.Empty;
}
