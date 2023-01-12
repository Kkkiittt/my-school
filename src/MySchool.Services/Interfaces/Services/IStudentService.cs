using My_School.Domain.Entities.Students;

using MySchool.Services.Common.Utils;
using MySchool.Services.Dtos.Students;
using MySchool.Services.ViewModels.Students;

namespace MySchool.Services.Interfaces.Services;

public interface IStudentService
{
	public Task<IEnumerable<StudentShortViewModel>> GetAllAsync(PaginationParams @params);

	public Task<IEnumerable<StudentShortViewModel>> GetStudyingAsync(PaginationParams @params);

	public Task<StudentFullViewModel> GetByIdAsync(long id);

	public Task<StudentRegisterViewModel> RegisterAsync(StudentRegisterDto dto);

	public Task<string> LoginAsync(StudentLoginDto dto);

	public Task<bool> DeleteByIdAsync(long id);

	public Task<bool> HireByIdAsync(long id);

	public Task<IEnumerable<Student>> GetFullAsync(PaginationParams @params);
}
