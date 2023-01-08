using MySchool.DataAccess.Interfaces;
using MySchool.Services.Common.Interfaces;

namespace MySchool.Services.Service;

public class GenericService : BasicService
{
	protected IFileService _filer { get; set; }
	public GenericService(IUnitOfWork repository, IFileService filer) : base(repository)
	{
		_filer = filer;
	}
}
