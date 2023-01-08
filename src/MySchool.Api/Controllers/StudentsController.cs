using Microsoft.AspNetCore.Mvc;

using MySchool.Services.Dtos.Students;
using MySchool.Services.Interfaces;

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
	public async Task<IActionResult> LoginAsync([FromForm]StudentLoginDto dto)
	{
		return Ok(await _studentService.LoginAsync(dto));
	}

	[HttpDelete("DeleteStudent")]
	public async Task<IActionResult> DeleteByIdAsync(long id)
	{
		return Ok(await _studentService.DeleteByIdAsync(id));
	}
}
