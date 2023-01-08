using My_School.Domain.Entities.Charters;
using My_School.Domain.Models.Common;

namespace MySchool.Services.ViewModels.Charters;

public class CharterShortViewModel : BaseEntity
{
	public DateTime Created { get; set; }

	public string StudentInfo { get; set; } = string.Empty;

	public static implicit operator CharterShortViewModel(Charter entity)
	{
		return new CharterShortViewModel()
		{
			Id = entity.Id,
			Created = entity.CreatedAt,
			StudentInfo = entity.Student.Info
		};
	}
}
