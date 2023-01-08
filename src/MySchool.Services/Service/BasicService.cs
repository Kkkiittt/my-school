using MySchool.DataAccess.Interfaces;
using MySchool.Services.Common.Helpers;
using MySchool.Services.Interfaces.Common;

namespace MySchool.Services.Service;

public class BasicService
{
	protected IUnitOfWork _repository { get; set; }
	protected IFileService _filer { get; set; }
	protected IHasher _hasher { get; set; }
	protected ViewModelHelper _viewModelHelper { get; set; }
	protected DtoHelper _dtoHelper { get; set; }
	public BasicService(IUnitOfWork repository, IFileService filer, IHasher hasher)
	{
		_repository = repository;
		_filer = filer;
		_hasher = hasher;
		_viewModelHelper = new(_repository);
		_dtoHelper = new(_filer, _hasher);
	}
}
