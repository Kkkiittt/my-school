using My_School.Domain.Models.Common;

namespace MySchool.Services.ViewModels.Students;

public class StudentShortViewModel : BaseEntity
{
	public string Info { get; set; } = string.Empty;

	public bool Studying { get; set; }

	public long Charters { get; set; }
}
