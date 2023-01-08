using MySchool.DataAccess.Interfaces;
using MySchool.Services.Dtos.Charters;
using MySchool.Services.Interfaces;
using MySchool.Services.Interfaces.Common;
using MySchool.Services.ViewModels.Charters;

namespace MySchool.Services.Service;

public class CharterService : BasicService, ICharterService
{

	public CharterService(IUnitOfWork repository, IFileService filer, IHasher hasher)
		: base(repository, filer, hasher)
	{
	}

	public async Task<bool> CreateAsync(CharterCreateDto dto)
	{
		throw new NotImplementedException();
	}

	public async Task<bool> DeleteByIdAsync(long id)
	{
		throw new NotImplementedException();
	}

	public async Task<IEnumerable<CharterShortViewModel>> GetAll()
	{
		throw new NotImplementedException();
	}

	public async Task<CharterFullViewModel> GetById(long id)
	{
		throw new NotImplementedException();
	}

	public async Task<IEnumerable<CharterShortViewModel>> GetByStudent(long studentId)
	{
		throw new NotImplementedException();
	}
}
