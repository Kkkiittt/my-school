using MySchool.DataAccess.Interfaces;
using MySchool.Services.Common.Interfaces;
using MySchool.Services.Interfaces;
using MySchool.Services.ViewModels.Common;

namespace MySchool.Services.Service;

public class OverallService : BasicService, IOverallService
{
	public OverallService(IUnitOfWork repository, IFileService filer, IHasher hasher) : base(repository, filer, hasher)
	{

	}

	public async Task<OverallViewModel> GetInfo()
	{
		throw new NotImplementedException();
	}
}
