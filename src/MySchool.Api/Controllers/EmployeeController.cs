using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using MySchool.Services.Common.Utils;
using MySchool.Services.Dtos.Employees;
using MySchool.Services.Interfaces.Services;

namespace My_School.Controllers;

[Route("api/employee")]
[ApiController]
public class EmployeeController : ControllerBase
{
	private readonly IEmployeeService _employeeService;
	private readonly int _pageSize = 20;

	public EmployeeController(IEmployeeService employeeService)
	{
		_employeeService = employeeService;
	}

	[HttpPost("register")]
	[AllowAnonymous]
	public async Task<IActionResult> RegisterAsync([FromForm] EmployeeRegisterDto dto)
	{
		return Ok(await _employeeService.RegisterAsync(dto));
	}

	[HttpPost("login")]
	[AllowAnonymous]
	public async Task<IActionResult> LoginAsync([FromForm] EmployeeLoginDto dto)
	{
		return Ok(await _employeeService.LoginAsync(dto));
	}

	[HttpDelete("")]
	[Authorize(Roles = "Admin")]
	public async Task<IActionResult> DeleteByIdAsync(long id)
	{
		return Ok(await _employeeService.DeleteByIdAsync(id));
	}


	[HttpPut("author/{id}")]
	[Authorize(Roles = "Admin")]
	public async Task<IActionResult> MakeAuthorAsync(long id)
	{
		return Ok(await _employeeService.MakeAuthor(id));
	}

	[HttpGet("")]
	[Authorize(Roles = "Author, Teacher, Admin")]
	public async Task<IActionResult> GetEmployeesAsync(int page = 1)
	{
		return Ok(await _employeeService.GetAll(new PaginationParams(page, _pageSize)));
	}
}
