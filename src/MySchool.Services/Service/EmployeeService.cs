using MySchool.Services.Dtos.Employees;
using MySchool.Services.Interfaces;

namespace MySchool.Services.Service;

public class EmployeeService : IEmployeeService
{
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
}
