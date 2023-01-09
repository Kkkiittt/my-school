using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using MySchool.Services.Dtos.Common;
using MySchool.Services.Dtos.Students;
using MySchool.Services.Interfaces;
using MySchool.Services.Interfaces.Common;
using MySchool.Services.Service;
using MySchool.Services.Service.Common;

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
	public async Task<IActionResult> SendCode([FromForm] int id)
	{
		return Ok(await _confirmationService.SendCode(id));
	}

	[HttpPost("ConfirmCode")]
	public async Task<IActionResult> ConfirmCode([FromForm] CodeConfirmDto dto)
	{
		return Ok(await _confirmationService.ConfirmCode(dto));
	}


}
