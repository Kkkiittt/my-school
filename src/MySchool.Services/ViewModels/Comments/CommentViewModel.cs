using My_School.Domain.Models.Common;

namespace MySchool.Services.ViewModels.Comments;

public class CommentViewModel : BaseEntity
{
	public string Content { get; set; } = string.Empty;

	public string StudentName { get; set; } = string.Empty;
}
