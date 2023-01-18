using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using MySchool.Services.Common.Utils;
using MySchool.Services.Dtos.Students;
using MySchool.Services.Interfaces.Services;

namespace My_School.Controllers;

[Route("api/students")]
[ApiController]
public class StudentsController : ControllerBase
{
	private readonly IStudentService _studentService;
	private readonly int _pageSize = 20;
	public StudentsController(IStudentService studentService)
	{
		_studentService = studentService;
	}

	//register
	[HttpPost("register")]
	[Authorize(Roles = "Author, Admin")]
	public async Task<IActionResult> RegisterAsync([FromForm] StudentRegisterDto dto)
	{
		return Ok(await _studentService.RegisterAsync(dto));
	}

	//students login
	[HttpPost("login")]
	[AllowAnonymous]
	public async Task<IActionResult> LoginAsync([FromForm] StudentLoginDto dto)
	{
		return Ok(await _studentService.LoginAsync(dto));
	}

	[HttpGet("all")]
	[AllowAnonymous]
	public async Task<IActionResult> GetAllAsync(int page = 1)
			=> Ok(await _studentService.GetAllAsync(new PaginationParams(page, _pageSize)));

	[HttpGet("study")]
	[AllowAnonymous]
	public async Task<IActionResult> GetByStudying(int page = 1)
			=> Ok(await _studentService.GetStudyingAsync(new PaginationParams(page, _pageSize)));

	[HttpDelete("{id}")]
	[Authorize(Roles = "Admin")]
	public async Task<IActionResult> DeleteByIdAsync(long id)
	{
		return Ok(await _studentService.DeleteByIdAsync(id));
	}

	[HttpGet("full")]
	[Authorize(Roles = "Author, Admin")]
	public async Task<IActionResult> GetFullAsync(int page = 1)
	{
		return Ok(await _studentService.GetFullAsync(new PaginationParams(page, _pageSize)));
	}

	[HttpDelete("hire/{id}")]
	[Authorize(Roles = "Author, Admin")]
	public async Task<IActionResult> HireStudentAsync(int id)
	{
		return Ok(await _studentService.HireByIdAsync(id));
	}
}
