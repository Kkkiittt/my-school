using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
