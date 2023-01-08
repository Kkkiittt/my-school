using MySchool.Services.Dtos.Employees;

namespace MySchool.Services.Interfaces;

public interface IEmployeeService
{
	public Task<bool> RegisterAsync(EmployeeRegisterDto dto);

	public Task<string> LoginAsync(EmployeeLoginDto dto);

	public Task<bool> DeleteByIdAsync(long id);

	public Task<bool> MakeAuthor(long id);
}
