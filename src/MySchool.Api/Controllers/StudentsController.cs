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
	public async Task<IActionResult> GetAllAsync(
		[FromQuery] PaginationParams @params)
			=> Ok(await _studentService.GetAllAsync(@params));

	[HttpGet ("GetStudying")]
	public async Task<IActionResult> GetByStudying(
		[FromQuery] PaginationParams @params)
			=> Ok(await _studentService.GetStudyingAsync(@params));

	[HttpDelete("DeleteStudent")]
	public async Task<IActionResult> DeleteByIdAsync(long id)
	{
		return Ok(await _studentService.DeleteByIdAsync(id));
	}

	[HttpGet("GetStudying")]
	public async Task<IActionResult> GetStudying()
	{
		return Ok(await _studentService.GetStudyingAsync());
	}

	[HttpGet("GetAll")]
	public async Task<IActionResult> GetAll()
	{
		return Ok(await _studentService.GetAllAsync());
	}
}
