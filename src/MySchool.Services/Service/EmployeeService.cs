using MySchool.DataAccess.Interfaces;
using MySchool.Services.Dtos.Employees;
using MySchool.Services.Interfaces;

namespace MySchool.Services.Service;

public class EmployeeService : GenericService, IEmployeeService
{
	public EmployeeService(IUnitOfWork repository) : base(repository)
	{

	}

	public Task<bool> DeleteByIdAsync(long id)
	{
		throw new NotImplementedException();
	}

	public Task<string> LoginAsync(EmployeeLoginDto dto)
	{
		throw new NotImplementedException();
	}

	public Task<bool> MakeAuthor(long id)
	{
		throw new NotImplementedException();
	}

	public Task<bool> RegisterAsync(EmployeeRegisterDto dto)
	{
		throw new NotImplementedException();
	}

	Task<bool> IEmployeeService.DeleteByIdAsync(long id)
	{
		throw new NotImplementedException();
	}

	Task<string> IEmployeeService.LoginAsync(EmployeeLoginDto dto)
	{
		throw new NotImplementedException();
	}

	Task<bool> IEmployeeService.MakeAuthor(long id)
	{
		throw new NotImplementedException();
	}

	Task<bool> IEmployeeService.RegisterAsync(EmployeeRegisterDto dto)
	{
		throw new NotImplementedException();
	}
}
