using MySchool.DataAccess.Interfaces;
using MySchool.Services.Common.Interfaces;
using MySchool.Services.Dtos.Students;
using MySchool.Services.Interfaces;
using MySchool.Services.ViewModels.Students;

namespace MySchool.Services.Service;

public class StudentService : BasicService, IStudentService
{
	public StudentService(IUnitOfWork repository, IFileService filer, IHasher hasher) 
		: base(repository, filer, hasher)
	{

	}

	public async Task<bool> DeleteByIdAsync(long id)
	{
		throw new NotImplementedException();
	}

	public async Task<string> LoginAsync(StudentLoginDto dto)
	{
		throw new NotImplementedException();
	}

	public async Task<StudentRegisterViewModel> RegisterAsync(StudentRegisterDto dto)
	{
		throw new NotImplementedException();
	}
}
