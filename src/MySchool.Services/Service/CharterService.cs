using MySchool.Services.Dtos.Charters;
using MySchool.Services.Interfaces;
using MySchool.Services.ViewModels.Charters;

namespace MySchool.Services.Service;

public class CharterService : ICharterService
{
	public Task<bool> CreateAsync(CharterCreateDto dto)
	{
		throw new NotImplementedException();
	}

	public Task<bool> DeleteByIdAsync(long id)
	{
		throw new NotImplementedException();
	}

	public Task<IEnumerable<CharterShortViewModel>> GetAll()
	{
		throw new NotImplementedException();
	}

	public Task<CharterFullViewModel> GetById(long id)
	{
		throw new NotImplementedException();
	}

	public Task<IEnumerable<CharterShortViewModel>> GetByStudent(long studentId)
	{
		throw new NotImplementedException();
	}
}
