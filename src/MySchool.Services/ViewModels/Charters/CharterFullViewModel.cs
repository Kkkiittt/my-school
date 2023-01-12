using My_School.Domain.Common;
using My_School.Domain.Entities.Charters;

using MySchool.Services.ViewModels.Students;

namespace MySchool.Services.ViewModels.Charters;

public class CharterFullViewModel : BaseEntity
{
	public string Image { get; set; } = string.Empty;

	public StudentShortViewModel Student { get; set; }

	public DateTime Created { get; set; }

	public static implicit operator CharterFullViewModel(Charter entity)
	{
		return new CharterFullViewModel()
		{
			Id = entity.Id,
			Image = entity.Image,
			Created = entity.CreatedAt
		};
	}
}
