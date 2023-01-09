using Microsoft.AspNetCore.Mvc;

using MySchool.Services.Common.Utils;
using MySchool.Services.Dtos.Articles;
using MySchool.Services.Interfaces;

namespace My_School.Controllers;

[Route("api/article")]
[ApiController]
public class ArticleController : ControllerBase
{
	private readonly IArticleService _articleService;

	public ArticleController(IArticleService articleService)
	{
		_articleService = articleService;
	}

	[HttpPost("ArticleCreate")]
	public async Task<IActionResult> CreateAsync([FromForm] ArticleCreateDto dto)
	{
		return Ok(await _articleService.CreateAsync(dto));
	}

	[HttpDelete("ArticleDelete")]
	public async Task<IActionResult> DeleteByIdAsync(long id)
	{
		return Ok(await _articleService.DeleteByIdAsync(id));
	}

	[HttpGet("ArticleGet")]
	public async Task<IActionResult> GetById(long id)
	{
		return Ok(await _articleService.GetById(id));
	}

	[HttpGet("GetAllArticles")]
	public async Task<IActionResult> GetAllAsync(
		[FromQuery] PaginationParams @params)
			=> Ok(await _articleService.GetAll(@params));


	[HttpGet("GetArticelByAuthor")]
	public async Task<IActionResult> GetByAuthorAsync(long authorId)
	{
		return Ok(await _articleService.GetByAuthor(authorId));
	}
}
