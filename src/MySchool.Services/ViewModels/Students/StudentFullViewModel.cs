using My_School.Domain.Entities.Comments;
using My_School.Domain.Entities.Students;
using My_School.Domain.Models.Common;

using MySchool.Services.ViewModels.Charters;
using MySchool.Services.ViewModels.Comments;

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
			Info = entity.Info,
			Studying = entity.Studying
		};
	}

}
