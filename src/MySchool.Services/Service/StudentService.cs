using MySchool.DataAccess.DbContexts;
using MySchool.DataAccess.Interfaces;
using MySchool.Services.Common.Exceptions;
using MySchool.Services.Dtos.Students;
using MySchool.Services.Interfaces;
using MySchool.Services.Interfaces.Common;
using MySchool.Services.Service.Common;
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

	public async Task<IEnumerable<StudentShortViewModel>> GetAllAsync()
	{
		try
		{
			return _repository.Students.GetAll().OrderByDescending(x => x.Studying)
				.Select(x => _viewModelHelper.ToShort(x));
		}
		catch
		{ 
			return Enumerable.Empty<StudentShortViewModel>();					
		}
										   
	}

	public async Task<StudentFullViewModel> GetByIdAsync(long id)
	{
		try
		{
			var entity = await _repository.Students.FindByIdAsync(id);
			if (entity == null)
				throw new Exception();
			return _viewModelHelper.ToFull(entity);
		}
		catch 
		{
			throw new StatusCodeException(System.Net.HttpStatusCode.NotFound, "Not found student on this id");
		}
	}

	public async Task<IEnumerable<StudentShortViewModel>> GetStudyingAsync()
	{
		try
		{
			return _repository.Students.Where(x => x.Studying == true).OrderByDescending(x => x.Studying)
				.Select(x => _viewModelHelper.ToShort(x));
		}
		catch
		{
			return Enumerable.Empty<StudentShortViewModel>();
		}
	}

	public async Task<string> LoginAsync(StudentLoginDto dto)
	{
		try
		{
			if (_repository.Students.GetAll().Any(x => x.Id == dto.Id && x.Pin == _hasher.Hash(dto.Pin.ToString(), "")))
			{
				//return _au.GenerateToken();
			}
			else throw new Exception();

		}
		catch 
		{
			throw new Exception("Password is wrong");	
		}
		
		
	}

	public async Task<StudentRegisterViewModel> RegisterAsync(StudentRegisterDto dto)
	{
		try
		{
			
			if(_repository.Students.GetAll().Any(x=>x.Info==dto.Info)) throw new Exception();
			var entity = await _dtoHelper.ToEntity(dto);
			var PinCode = entity.Pin;
			entity.Pin = _hasher.Hash(entity.Pin, "");
			_repository.Students.Add(entity);
			var studentId = _repository.Students.GetAll().MaxBy(x => x.Id).Id;
			return new StudentRegisterViewModel
			{
				Pin = int.Parse(PinCode),
				Id = studentId
			};
			
		}
		catch 
		{

			throw new Exception("This student already exist");
		}
	}
}
