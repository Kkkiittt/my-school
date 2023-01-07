using Microsoft.AspNetCore.Http;

namespace MySchool.Services.Common.Interfaces;

public interface IFileService
{
	public Task<string> SaveImageAsync(IFormFile image);
}
