using My_School.Domain.Common;
using My_School.Domain.Entities.Students;

namespace MySchool.Services.ViewModels.Students;

public class StudentShortViewModel : BaseEntity
{
	public string Info { get; set; } = string.Empty;

	public bool Studying { get; set; }

	public long Charters { get; set; }

	public static implicit operator StudentShortViewModel(Student entity)
	{
		return new StudentShortViewModel()
		{
			Id = entity.Id,
			Info = entity.Info,
			Studying = entity.Studying
		};
	}
}
