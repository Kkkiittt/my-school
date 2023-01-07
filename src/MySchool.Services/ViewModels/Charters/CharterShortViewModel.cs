using My_School.Domain.Models.Common;

namespace MySchool.Services.ViewModels.Charters;

public class CharterShortViewModel : BaseEntity
{
	public DateTime Created { get; set; }

	public string StudentInfo { get; set; } = string.Empty;
}
