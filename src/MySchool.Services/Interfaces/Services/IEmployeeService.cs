using MySchool.Services.Common.Utils;
using MySchool.Services.Dtos.Employees;
using MySchool.Services.ViewModels.Employees;

namespace MySchool.Services.Interfaces.Services;

public interface IEmployeeService
{
	public Task<IEnumerable<EmployeeShortViewModel>> GetAll(PaginationParams @params);

	public Task<bool> RegisterAsync(EmployeeRegisterDto dto);

	public Task<string> LoginAsync(EmployeeLoginDto dto);

	public Task<bool> DeleteByIdAsync(long id);

	public Task<bool> MakeAuthor(long id);
}
