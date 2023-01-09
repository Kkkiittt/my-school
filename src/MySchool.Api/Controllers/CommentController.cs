using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using MySchool.Services.Dtos.Comments;
using MySchool.Services.Interfaces;

namespace My_School.Controllers;

[Route("api/comment")]
[ApiController]
public class CommentController : ControllerBase
{
	private readonly ICommentService _commentService;

	public CommentController(ICommentService commentService)
	{
		_commentService = commentService;
	}

	[HttpPost("CommentCreate")]
	[Authorize(Roles = "Student")]
	public async Task<IActionResult> CreateAsync([FromForm] CommentCreateDto dto)
	{
		return Ok(await _commentService.CreateAsync(dto));
	}

	[HttpGet("GetCommentByArticle")]
	[AllowAnonymous]
	public async Task<IActionResult> GetByArticleAsync(long articleId)
	{
		return Ok(await _commentService.GetByArticleAsync(articleId));
	}

	[HttpDelete("CommentDelete")]
	[Authorize(Roles = "Author, Admin, Teacher")]
	public async Task<IActionResult> DeleteByIdAsync(long id)
	{
		return Ok(await _commentService.DeleteByIdAsyc(id));
	}
}
