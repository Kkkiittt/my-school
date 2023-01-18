using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using MySchool.Services.Common.Utils;
using MySchool.Services.Dtos.Articles;
using MySchool.Services.Interfaces.Services;

namespace My_School.Controllers;

[Route("api/article")]
[ApiController]
public class ArticleController : ControllerBase
{
	private readonly IArticleService _articleService;
	private readonly int _pageSize = 20;

	public ArticleController(IArticleService articleService)
	{
		_articleService = articleService;
	}

	[HttpPost("")]
	[Authorize(Roles = "Author, Admin")]
	public async Task<IActionResult> CreateAsync([FromForm] ArticleCreateDto dto)
	{
		return Ok(await _articleService.CreateAsync(dto));
	}

	[HttpDelete("{id}")]
	[Authorize(Roles = "Author, Admin")]
	public async Task<IActionResult> DeleteByIdAsync(long id)
	{
		return Ok(await _articleService.DeleteByIdAsync(id));
	}

	[HttpGet("{id}")]
	[AllowAnonymous]
	public async Task<IActionResult> GetById(long id)
	{
		return Ok(await _articleService.GetById(id));
	}

	[HttpGet("all")]
	[AllowAnonymous]
	public async Task<IActionResult> GetAllAsync(int page = 1)
			=> Ok(await _articleService.GetAll(new PaginationParams(page, _pageSize)));


	[HttpGet("author/{authorId}")]
	[Authorize(Roles = "Teacher, Author, Admin")]
	public async Task<IActionResult> GetByAuthorAsync(long authorId)
	{
		return Ok(await _articleService.GetByAuthor(authorId));
	}
}
