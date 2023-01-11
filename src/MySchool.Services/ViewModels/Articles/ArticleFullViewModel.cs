using My_School.Domain.Common;
using My_School.Domain.Entities.Articles;

using MySchool.Services.ViewModels.Comments;

namespace MySchool.Services.ViewModels.Articles;


public class ArticleFullViewModel : BaseEntity
{
	public string HTML { get; set; } = string.Empty;

	public string AuthorName { get; set; } = string.Empty;

	public string AuthorImage { get; set; } = string.Empty;

	public long Views { get; set; }

	public string Title { get; set; } = string.Empty;

	public List<CommentViewModel> Comments { get; set; } = new();

	public DateTime Created { get; set; }

	public static implicit operator ArticleFullViewModel(Article entity)
	{
		return new ArticleFullViewModel()
		{
			Id = entity.Id,
			HTML = entity.HTML,
			Views = entity.Views,
			Title = entity.Title,
			Created = entity.CreatedAt,
			AuthorImage = entity.Employee.Image,
			AuthorName = entity.Employee.Name,
		};
	}
}
