using MySchool.DataAccess.Interfaces;
using MySchool.Services.Dtos.Common;
using MySchool.Services.Interfaces.Common;

namespace MySchool.Services.Service.Common;

public class PhoneService : BasicService, IPhoneService
{
	public PhoneService(IUnitOfWork repository, IFileService filer, IHasher hasher, IViewModelHelper viewModelHelper, IDtoHelper dtoHelper, IAuthManager authManager) : base(repository, filer, hasher, viewModelHelper, dtoHelper, authManager)
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
