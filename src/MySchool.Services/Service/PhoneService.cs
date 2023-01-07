using MySchool.DataAccess.Interfaces;
using MySchool.Services.Dtos.Common;
using MySchool.Services.Interfaces;

namespace MySchool.Services.Service;

public class PhoneService : BasicService, IPhoneService
{
	public PhoneService(IUnitOfWork repository) : base(repository)
	{

	}

	public Task<bool> ConfirmCode(CodeConfirmDto dto)
	{
		throw new NotImplementedException();
	}

	public Task<bool> SendCode(long authorId)
	{
		throw new NotImplementedException();
	}
}
