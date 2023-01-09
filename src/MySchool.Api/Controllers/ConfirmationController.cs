using Microsoft.AspNetCore.Mvc;

using MySchool.Services.Dtos.Common;
using MySchool.Services.Interfaces.Common;

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

	[HttpPost("SendCode")]
	public async Task<IActionResult> SendCode([FromForm] string email)
	{
		return Ok(await _confirmationService.SendCode(email));
	}

	[HttpPost("ConfirmCode")]
	public async Task<IActionResult> ConfirmCode([FromForm] CodeConfirmDto dto)
	{
		return Ok(await _confirmationService.ConfirmCode(dto));
	}


}
