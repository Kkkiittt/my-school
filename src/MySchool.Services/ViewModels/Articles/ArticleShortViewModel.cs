using My_School.Domain.Common;
using My_School.Domain.Entities.Articles;

namespace MySchool.Services.ViewModels.Articles;

public class ArticleShortViewModel : BaseEntity
{
	public string Title { get; set; } = string.Empty;

	public string Image { get; set; } = string.Empty;

	public long Views { get; set; }

	public static implicit operator ArticleShortViewModel(Article entity)
	{
		return new ArticleShortViewModel()
		{
			Id = entity.Id,
			Title = entity.Title,
			Image = entity.Image,
			Views = entity.Views
		};
	}

}
