using My_School.Domain.Entities.Comments;
using My_School.Domain.Models.Common;

namespace MySchool.Services.ViewModels.Comments;

public class CommentViewModel : BaseEntity
{
	public string Content { get; set; } = string.Empty;

	public string StudentName { get; set; } = string.Empty;

	public static implicit operator CommentViewModel(Comment entity)
	{
		return new CommentViewModel()
		{
			Id = entity.Id,
			Content = entity.Content,
			StudentName = entity.Student.Info
		};
	}
}
