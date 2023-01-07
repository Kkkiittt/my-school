using System.ComponentModel.DataAnnotations;

using Microsoft.AspNetCore.Http;

namespace MySchool.Services.Dtos.Articles;

public class ArticleCreateDto
{
	[Required]
	public string HTML { get; set; } = string.Empty;
	[Required]
	public int EmployeeId { get; set; }
	[Required]
	public string Title { get; set; } = string.Empty;
	public IFormFile? Image { get; set; }
}
