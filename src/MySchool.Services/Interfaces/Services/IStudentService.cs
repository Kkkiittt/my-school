using MySchool.Services.Dtos.Students;
using MySchool.Services.ViewModels;
using MySchool.Services.ViewModels.Students;

namespace MySchool.Services.Interfaces;

public interface IStudentService
{
	public Task<IEnumerable<StudentShortViewModel>> GetAllAsync();

	public Task<IEnumerable<StudentShortViewModel>> GetStudyingAsync();

	public Task<StudentFullViewModel> GetByIdAsync(long id);

	public Task<StudentRegisterViewModel> RegisterAsync(StudentRegisterDto dto);

	public Task<string> LoginAsync(StudentLoginDto dto);

	public Task<bool> DeleteByIdAsync(long id);
}
