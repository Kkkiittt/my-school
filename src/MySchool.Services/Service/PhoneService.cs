using MySchool.DataAccess.Interfaces;
using MySchool.Services.Common.Interfaces;
using MySchool.Services.Dtos.Common;
using MySchool.Services.Interfaces;

namespace MySchool.Services.Service;

public class PhoneService : BasicService, IPhoneService
{
	public PhoneService(IUnitOfWork repository, IFileService filer, IHasher hasher)
		: base(repository, filer, hasher)
	{

	}

	public async Task<bool> ConfirmCode(CodeConfirmDto dto)
	{
		throw new NotImplementedException();
	}

	public async Task<bool> SendCode(long authorId)
	{
		throw new NotImplementedException();
	}
}
