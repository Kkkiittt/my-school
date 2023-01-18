
using System.ComponentModel.DataAnnotations;

using My_School.Domain.Entities.Comments;

namespace MySchool.Services.Dtos.Comments;

public class CommentCreateDto
{
	[Required]
	public int ArticleId { get; set; }

	[Required]
	public string Content { get; set; } = string.Empty;
	public static implicit operator Comment(CommentCreateDto dto)
	{
		return new Comment()
		{
			Content = dto.Content,
			ArticleId = dto.ArticleId,
			CreatedAt = DateTime.Now
		};
	}
}
