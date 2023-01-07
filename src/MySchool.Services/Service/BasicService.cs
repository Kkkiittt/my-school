using MySchool.DataAccess.Interfaces;

namespace MySchool.Services.Service;

public class BasicService
{
	protected IUnitOfWork _repository { get; set; }

	public BasicService(IUnitOfWork repository)
	{
		_repository = repository;
	}
}
