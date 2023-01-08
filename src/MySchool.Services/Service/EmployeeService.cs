using MySchool.DataAccess.Interfaces;
using MySchool.Services.Dtos.Employees;
using MySchool.Services.Interfaces;
using MySchool.Services.Interfaces.Common;

namespace MySchool.Services.Service;

public class EmployeeService : GenericService, IEmployeeService
{
	public EmployeeService(IUnitOfWork repository, IFileService filer, IHasher hasher) : base(repository, filer, hasher)
	{

	}

	public async Task<bool> DeleteByIdAsync(long id)
	{
		throw new NotImplementedException();
	}

	public async Task<string> LoginAsync(EmployeeLoginDto dto)
	{
		throw new NotImplementedException();
	}

	public async Task<bool> MakeAuthor(long id)
	{
		throw new NotImplementedException();
	}

	public async Task<bool> RegisterAsync(EmployeeRegisterDto dto)
	{
		throw new NotImplementedException();
	}
}
