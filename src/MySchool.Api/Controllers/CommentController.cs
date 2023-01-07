using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySchool.Services.Dtos.Articles;
using MySchool.Services.Dtos.Comments;
using MySchool.Services.Interfaces;
using MySchool.Services.ViewModels.Comments;

namespace My_School.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CommentController : ControllerBase
{
	private readonly ICommentService _commentService;

	public CommentController(ICommentService commentService)
	{
		_commentService = commentService;
	}

	[HttpPost("CommnetCreate")]
	public async Task<IActionResult> CreateAsync([FromForm] CommentCreateDto dto)
	{
		return Ok(await _commentService.CreateAsync(dto));
	}

	[HttpGet("GetCommnetByArticle")]
	public async Task<IActionResult> GetByArticleAsync(long articleId)
	{
		return Ok(await _commentService.GetByArticleAsync(articleId));
	}

	[HttpDelete("CommnetDelete")]
	public async Task<IActionResult> DeleteByIdAsync(long id)
	{
		return Ok(await _commentService.DeleteByIdAsyc(id));
	}
}
