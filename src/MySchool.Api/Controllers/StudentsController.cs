using Microsoft.AspNetCore.Mvc;

using MySchool.Services.Common.Utils;
using MySchool.Services.Dtos.Students;
using MySchool.Services.Interfaces;
using MySchool.Services.Service;

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
	[HttpPost("StudentRegister")]
	public async Task<IActionResult> RegisterAsync([FromForm] StudentRegisterDto dto)
	{
		return Ok(await _studentService.RegisterAsync(dto));
	}

	//students login
	[HttpPost("StudentLogin")]
	public async Task<IActionResult> LoginAsync([FromForm] StudentLoginDto dto)
	{
		return Ok(await _studentService.LoginAsync(dto));
	}

	[HttpGet("GetAllStudents")]
	public async Task<IActionResult> GetAllAsync(int page = 1)
			=> Ok(await _studentService.GetAllAsync(new PaginationParams(page, _pageSize)));

	[HttpGet("GetStudying")]
	public async Task<IActionResult> GetByStudying(int page = 1)
			=> Ok(await _studentService.GetStudyingAsync(new PaginationParams(page, _pageSize)));

	[HttpDelete("DeleteStudent")]
	public async Task<IActionResult> DeleteByIdAsync(long id)
	{
		return Ok(await _studentService.DeleteByIdAsync(id));
	}
}
