using MySchool.DataAccess.Interfaces;
using MySchool.Services.Interfaces.Common;
using MySchool.Services.Interfaces.Services;
using MySchool.Services.ViewModels.Common;

namespace MySchool.Services.Service;

public class OverallService : BasicService, IOverallService
{
	public OverallService(IUnitOfWork repository, IFileService filer, IHasher hasher, IViewModelHelper viewModelHelper, IDtoHelper dtoHelper, IAuthManager authManager, IPaginatorService paginator) : base(repository, filer, hasher, viewModelHelper, dtoHelper, authManager, paginator)
	{

	}

	public async Task<OverallViewModel> GetInfo()
	{
		return new OverallViewModel
		{
			Students = _repository.Students.GetAll().Count(x => x.Studying),
			Teachers = _repository.Employees.GetAll().Count()
		};
	}
}
