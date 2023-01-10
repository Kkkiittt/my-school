using Microsoft.EntityFrameworkCore;

using MySchool.DataAccess.Interfaces;
using MySchool.Services.Common.Exceptions;
using MySchool.Services.Common.Utils;
using MySchool.Services.Dtos.Students;
using MySchool.Services.Interfaces;
using MySchool.Services.Interfaces.Common;
using MySchool.Services.ViewModels.Students;

namespace MySchool.Services.Service;

public class StudentService : BasicService, IStudentService
{
	public StudentService(IUnitOfWork repository, IFileService filer, IHasher hasher, IViewModelHelper viewModelHelper, IDtoHelper dtoHelper, IAuthManager authManager) : base(repository, filer, hasher, viewModelHelper, dtoHelper, authManager)
	{

	}

	public async Task<bool> DeleteByIdAsync(long id)
	{
		try
		{
			_repository.Students.Delete(id);
			return await _repository.SaveChanges() > 0;
		}
		catch
		{
			return false;
		}
	}

	public async Task<IEnumerable<StudentShortViewModel>> GetAllAsync(PaginationParams @params)
	{
		try
		{
			IQueryable<StudentShortViewModel> query = _repository.Students.GetAll().OrderByDescending(x => x.Studying)
				.Select(x => _viewModelHelper.ToShort(x));

			return await query.Skip((@params.PageNumber - 1) * @params.PageSize).Take(@params.PageSize)
						 .ToListAsync();
		}
		catch
		{
			return Enumerable.Empty<StudentShortViewModel>();
		}

	}

	public async Task<StudentFullViewModel> GetByIdAsync(long id)
	{
		//try
		//{
			My_School.Domain.Entities.Students.Student? entity = await _repository.Students.FindByIdAsync(id);
			if(entity == null)
				throw new Exception();
			return _viewModelHelper.ToFull(entity);
		//}
		//catch
		//{
		//	throw new StatusCodeException(System.Net.HttpStatusCode.NotFound, "Not found student on this id");
		//}
	}

	public async Task<IEnumerable<StudentShortViewModel>> GetStudyingAsync(PaginationParams @params)
	{
		//try
		//{
			IQueryable<StudentShortViewModel> query = _repository.Students.Where(x => x.Studying)
				.Select(x => _viewModelHelper.ToShort(x));

			return await query.Skip((@params.PageNumber - 1) * @params.PageSize).Take(@params.PageSize)
						 .ToListAsync();
		//}
		//catch
		//{
		//	return Enumerable.Empty<StudentShortViewModel>();
		//}
	}

	public async Task<string> LoginAsync(StudentLoginDto dto)
	{
		//try
		//{
			My_School.Domain.Entities.Students.Student? entity = _repository.Students.GetAll().FirstOrDefault(x => x.Id == dto.Id );

		if (entity == null)
			throw new Exception("student is null");
		var passwordhashed = _hasher.Hash(dto.Pin.ToString(), "");
		if (entity.Pin != passwordhashed)
			throw new Exception("Password is incorrect");
		return _authManager.GenerateToken(entity);

		//}
		//catch
		//{
		//	throw new Exception("Something is wrong");
		//}


	}

	public async Task<StudentRegisterViewModel> RegisterAsync(StudentRegisterDto dto)
	{
		//try
		//{

			if(_repository.Students.GetAll().Any(x => x.Info == dto.Info))
				throw new Exception();
			My_School.Domain.Entities.Students.Student entity = await _dtoHelper.ToEntity(dto);
			string PinCode = entity.Pin;
			entity.Pin = _hasher.Hash(entity.Pin, "");
			_repository.Students.Add(entity);
		    await _repository.SaveChanges();
			long studentId = _repository.Students.GetAll().FirstOrDefaultAsync(x => x.Info == dto.Info).Id;
			return new StudentRegisterViewModel
			{
				Pin = int.Parse(PinCode),
				Id = studentId
			};

		//}
		//catch
		//{

		//	throw new Exception("This student already exist");
		//}
	}
}
