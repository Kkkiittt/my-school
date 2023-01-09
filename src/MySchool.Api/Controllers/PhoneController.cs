using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySchool.Services.Dtos.Common;
using MySchool.Services.Dtos.Students;
using MySchool.Services.Interfaces;
using MySchool.Services.Interfaces.Common;
using MySchool.Services.Service;
using MySchool.Services.Service.Common;

namespace My_School.Controllers;

[Route("api/phonesSrvice")]
[ApiController]

public class PhoneController : ControllerBase
{
	private readonly IPhoneService _phoneService;

	public PhoneController(IPhoneService phoneService)
	{
		_phoneService = phoneService;
	}

	[HttpPost("SendCode")]
	public async Task<IActionResult> SendCode([FromForm] int id)
	{
		return Ok(await _phoneService.SendCode(id));
	}

	[HttpPost("ConfirmCode")]
	public async Task<IActionResult> ConfirmCode([FromForm] CodeConfirmDto dto)
	{
		return Ok(await _phoneService.ConfirmCode(dto));
	}


}
