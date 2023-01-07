using Microsoft.EntityFrameworkCore;
using MySchool.Services.Dtos.Students;

namespace MySchool.Services.Interfaces;

public interface IStudentService
{
	public Task<bool> RegisterAsync(StudentRegisterDto dto);
	public Task<string> LoginAsync(StudentLoginDto dto);
	public Task<bool> DeleteByIdAsync(long id);
}
