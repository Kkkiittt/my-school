using System.ComponentModel.DataAnnotations;

using Microsoft.AspNetCore.Http;

using My_School.Domain.Entities.Articles;

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
	public static implicit operator Article(ArticleCreateDto dto)
	{
		return new Article()
		{
			HTML = dto.HTML,
			EmployeeId = dto.EmployeeId,
			Title = dto.Title,
			CreatedAt = DateTime.Now,
			Views = 0
		};
	}
}
