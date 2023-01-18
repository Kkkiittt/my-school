using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using MySchool.Services.Common.Utils;
using MySchool.Services.Dtos.Charters;
using MySchool.Services.Interfaces.Services;

namespace My_School.Controllers;

[Route("api/charters")]
[ApiController]
public class CharterController : ControllerBase
{
	private readonly int _pageSize = 20;
	private readonly ICharterService _charterService;

	public CharterController(ICharterService charterService)
	{
		_charterService = charterService;
	}
	[HttpPost("")]
	[Authorize(Roles = "Author, Admin")]
	public async Task<IActionResult> CreateAsync([FromForm] CharterCreateDto dto)
	{
		return Ok(await _charterService.CreateAsync(dto));

	}

	[HttpDelete("")]
	[Authorize(Roles = "Author, Admin")]
	public async Task<IActionResult> DeleteByIdAsync(long id)
	{
		return Ok(await _charterService.DeleteByIdAsync(id));
	}

	[HttpGet("all")]
	[AllowAnonymous]
	public async Task<IActionResult> GetAllAsync(int page = 1)
			=> Ok(await _charterService.GetAll(new PaginationParams(page, _pageSize)));

	[HttpGet("{id}")]
	[AllowAnonymous]
	public async Task<IActionResult> GetById(long id)
	{
		return Ok(await _charterService.GetById(id));
	}

	[HttpGet("student/{studentId}")]
	[Authorize(Roles = "Teacher, Author, Admin")]
	public async Task<IActionResult> GetByStudent(long studentId)
	{
		return Ok(await _charterService.GetByStudent(studentId));
	}
}
