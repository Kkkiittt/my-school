using My_School.Domain.Models.Common;

namespace MySchool.Services.ViewModels.Students;

public class StudnetLoginViewModel : BaseEntity
{
	public int Code { get; set; }

	public string Token { get; set; } = string.Empty;
}
