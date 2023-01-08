using MySchool.DataAccess.Interfaces;
using MySchool.Services.Common.Interfaces;
using MySchool.Services.Dtos.Employees;
using MySchool.Services.Interfaces;

namespace MySchool.Services.Service;

public class EmployeeService : GenericService, IEmployeeService
{
	public EmployeeService(IUnitOfWork repository, IFileService filer) : base(repository, filer)
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
