using My_School.Domain.Entities.Charters;

using MySchool.DataAccess.Interfaces;
using MySchool.Services.Common.Exceptions;
using MySchool.Services.Dtos.Charters;
using MySchool.Services.Interfaces;
using MySchool.Services.Interfaces.Common;
using MySchool.Services.ViewModels.Charters;

namespace MySchool.Services.Service;

public class CharterService : BasicService, ICharterService
{

	public CharterService(IUnitOfWork repository, IFileService filer, IHasher hasher, IViewModelHelper viewModelHelper, IDtoHelper dtoHelper, IAuthManager authManager) : base(repository, filer, hasher, viewModelHelper, dtoHelper, authManager)
	{
	}

	public async Task<bool> CreateAsync(CharterCreateDto dto)
	{
		try
		{
			Charter charter = await _dtoHelper.ToEntity(dto);
			_repository.Charters.Add(charter);
			return await _repository.SaveChanges() > 0;
		}
		catch
		{
			return false;
		}
	}

	public async Task<bool> DeleteByIdAsync(long id)
	{
		try
		{
			_repository.Charters.Delete(id);
			return await _repository.SaveChanges() > 0;
		}
		catch
		{
			return false;
		}
	}

	public async Task<IEnumerable<CharterShortViewModel>> GetAll()
	{
		try
		{
			return _repository.Charters.GetAll().OrderByDescending(x => x.CreatedAt).Select(x => _viewModelHelper.ToShort(x));
		}
		catch
		{
			return Enumerable.Empty<CharterShortViewModel>();
		}
	}

	public async Task<CharterFullViewModel> GetById(long id)
	{
		try
		{
			return await _repository.Charters.FindByIdAsync(id);
		}
		catch
		{
			throw new StatusCodeException(System.Net.HttpStatusCode.NotFound, "Charter not found by ID");
		}
	}

	public async Task<IEnumerable<CharterShortViewModel>> GetByStudent(long studentId)
	{
		try
		{
			return _repository.Charters.Where(x => x.StudentId == studentId).Select(x => _viewModelHelper.ToShort(x));
		}
		catch
		{
			throw new StatusCodeException(System.Net.HttpStatusCode.NotFound, "Charter not found by Student ID");
		}
	}
}
