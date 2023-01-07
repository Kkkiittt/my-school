using MySchool.Services.Dtos.Common;
using MySchool.Services.Interfaces;

namespace MySchool.Services.Service;

public class PhoneService : IPhoneService
{
	public Task<bool> ConfirmCode(CodeConfirmDto dto)
	{
		throw new NotImplementedException();
	}

	public Task<bool> SendCode(long authorId)
	{
		throw new NotImplementedException();
	}
}
