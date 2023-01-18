using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using MySchool.Services.Dtos.Common;
using MySchool.Services.Interfaces.Services;

namespace My_School.Controllers;

[Route("api/confirmService")]
[ApiController]
public class ConfirmationController : ControllerBase
{
	private readonly IConfirmationService _confirmationService;

	public ConfirmationController(IConfirmationService confirmationService)
	{
		_confirmationService = confirmationService;
	}

	[HttpPost("send")]
	[Authorize(Roles = "Author, Admin")]
	public async Task<IActionResult> SendCode([FromForm] string email)
	{
		return Ok(await _confirmationService.SendCode(email));
	}

	[HttpPost("confirm")]
	[AllowAnonymous]
	public async Task<IActionResult> ConfirmCode([FromForm] CodeConfirmDto dto)
	{
		return Ok(await _confirmationService.ConfirmCode(dto));
	}


}
