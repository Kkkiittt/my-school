using MySchool.Services.Dtos.Students;
using MySchool.Services.Interfaces;
using MySchool.Services.ViewModels.Students;

namespace MySchool.Services.Service;

public class StudentService : IStudentService
{
	public Task<bool> DeleteByIdAsync(long id)
	{
		throw new NotImplementedException();
	}

	public Task<string> LoginAsync(StudentLoginDto dto)
	{
		throw new NotImplementedException();
	}

	public Task<StudentRegisterViewModel> RegisterAsync(StudentRegisterDto dto)
	{
		throw new NotImplementedException();
	}
}
