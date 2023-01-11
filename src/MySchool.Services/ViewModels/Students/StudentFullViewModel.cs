using My_School.Domain.Common;
using My_School.Domain.Entities.Students;

using MySchool.Services.ViewModels.Charters;

namespace MySchool.Services.ViewModels.Students;

public class StudentFullViewModel : BaseEntity
{
	public string Info { get; set; } = string.Empty;

	public bool Studying { get; set; }

	public List<CharterShortViewModel> Charters { get; set; } = new();

	public static implicit operator StudentFullViewModel(Student entity)
	{
		return new StudentFullViewModel()
		{
			Id = entity.Id,
			Info = entity.Info,
			Studying = entity.Studying
		};
	}

}
