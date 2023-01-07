using MySchool.Services.Dtos.Employees;

namespace MySchool.Services.Interfaces;

public interface IEmployeeService
{
	public Task<bool> RegisterAsync(EmployeeRegisterDto dto);

	public Task<string> LoginAsync(EmployeeLoginDto dto);
}
