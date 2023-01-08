using MySchool.DataAccess.Interfaces;
using MySchool.Services.Common.Helpers;
using MySchool.Services.Interfaces.Common;

namespace MySchool.Services.Service;

public class BasicService
{
	protected IUnitOfWork _repository { get; set; }
	protected IFileService _filer { get; set; }
	protected IHasher _hasher { get; set; }
	protected IViewModelHelper _viewModelHelper { get; set; }
	protected IDtoHelper _dtoHelper { get; set; }
	public BasicService(IUnitOfWork repository, IFileService filer, IHasher hasher, IViewModelHelper viewModelHelper, IDtoHelper dtoHelper)
	{
		_repository = repository;
		_filer = filer;
		_hasher = hasher;
		_viewModelHelper = viewModelHelper;
		_dtoHelper = dtoHelper;
	}
}
