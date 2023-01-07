using MySchool.DataAccess.Interfaces;
using MySchool.Services.Interfaces;
using MySchool.Services.ViewModels.Common;

namespace MySchool.Services.Service;

public class OverallService : BasicService, IOverallService
{
	public OverallService(IUnitOfWork repository) : base(repository)
	{

	}

	public Task<OverallViewModel> GetInfo()
	{
		throw new NotImplementedException();
	}
}
