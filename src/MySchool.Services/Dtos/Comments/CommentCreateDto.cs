
using System.ComponentModel.DataAnnotations;

namespace MySchool.Services.Dtos.Comments;

public class CommentCreateDto
{
	[Required]
	public int StudentId { get; set; }
	[Required]
	public string Content { get; set; } = string.Empty;
}
