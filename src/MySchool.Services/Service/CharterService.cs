using Microsoft.EntityFrameworkCore;

using My_School.Domain.Entities.Charters;

using MySchool.DataAccess.Interfaces;
using MySchool.Services.Common.Utils;
using MySchool.Services.Dtos.Charters;
using MySchool.Services.Interfaces.Common;
using MySchool.Services.Interfaces.Services;
using MySchool.Services.ViewModels.Charters;

namespace MySchool.Services.Service;

public class CharterService : BasicService, ICharterService
{

	public CharterService(IUnitOfWork repository, IFileService filer, IHasher hasher, IViewModelHelper viewModelHelper, IDtoHelper dtoHelper, IAuthManager authManager, IPaginatorService paginator) : base(repository, filer, hasher, viewModelHelper, dtoHelper, authManager, paginator)
	{
	}

	public async Task<bool> CreateAsync(CharterCreateDto dto)
	{
		//try
		//{
		Charter charter = await _dtoHelper.ToEntity(dto);
		_repository.Charters.Add(charter);
		return await _repository.SaveChanges() > 0;
		//}
		//catch
		//{
		//	return false;
		//}
	}

	public async Task<bool> DeleteByIdAsync(long id)
	{
		//try
		//{
		_repository.Charters.Delete(id);
		return await _repository.SaveChanges() > 0;
		//}
		//catch
		//{
		//	return false;
		//}
	}

	public async Task<IEnumerable<CharterShortViewModel>> GetAll(PaginationParams @params)
	{
		//try
		//{
		var page = await _paginator.ToPagedAsync(_repository.Charters.GetAll().OrderByDescending(x => x.CreatedAt), @params.PageNumber, @params.PageSize);
		return page.Select(x => _viewModelHelper.ToShort(x));
		//}
		//catch
		//{
		//	return Enumerable.Empty<CharterShortViewModel>();
		//}
	}

	public async Task<CharterFullViewModel> GetById(long id)
	{
		//try
		//{
		return await _repository.Charters.FindByIdAsync(id);
		//}
		//catch
		//{
		//	throw new StatusCodeException(System.Net.HttpStatusCode.NotFound, "Charter not found by ID");
		//}
	}

	public async Task<IEnumerable<CharterShortViewModel>> GetByStudent(long studentId)
	{
		//try
		//{
		List<Charter> page = await _repository.Charters.Where(x => x.StudentId == studentId).ToListAsync();
		return page.Select(x => _viewModelHelper.ToShort(x));
		//}
		//catch
		//{
		//	throw new StatusCodeException(System.Net.HttpStatusCode.NotFound, "Charter not found by Student ID");
		//}
	}
}
