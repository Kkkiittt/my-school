using MySchool.DataAccess.Interfaces;
using MySchool.Services.Interfaces.Common;

namespace MySchool.Services.Service;

public class BasicService
{
	protected IUnitOfWork _repository { get; set; }
	protected IFileService _filer { get; set; }
	protected IHasher _hasher { get; set; }
	protected IViewModelHelper _viewModelHelper { get; set; }
	protected IDtoHelper _dtoHelper { get; set; }
	protected IAuthManager _authManager { get; set; }
	protected IPaginatorService _paginator;

	public BasicService(IUnitOfWork repository, IFileService filer, IHasher hasher, IViewModelHelper viewModelHelper, IDtoHelper dtoHelper, IAuthManager authManager, IPaginatorService paginator)
	{
		_repository = repository;
		_filer = filer;
		_hasher = hasher;
		_viewModelHelper = viewModelHelper;
		_dtoHelper = dtoHelper;
		_authManager = authManager;
		_paginator = paginator;
	}
}
