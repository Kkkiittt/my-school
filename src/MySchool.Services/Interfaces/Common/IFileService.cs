using Microsoft.AspNetCore.Http;

namespace MySchool.Services.Interfaces.Common;

public interface IFileService
{
	public Task<string> SaveImageAsync(IFormFile image);
}
