using My_School.Domain.Entities.Articles;
using My_School.Domain.Entities.Charters;
using My_School.Domain.Models.Common;
using System.Reflection.Metadata.Ecma335;

namespace MySchool.Services.ViewModels.Charters;

public class CharterShortViewModel : BaseEntity
{
	public DateTime Created { get; set; }

	public string StudentInfo { get; set; } = string.Empty;

	public static implicit operator CharterShortViewModel(Charter entity)
	{
		return new CharterShortViewModel()
		{
			Created = entity.CreatedAt,
		};
	} 
}
