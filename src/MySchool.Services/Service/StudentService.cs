using Microsoft.EntityFrameworkCore;

using My_School.Domain.Entities.Students;

using MySchool.DataAccess.Interfaces;
using MySchool.Services.Common.Utils;
using MySchool.Services.Dtos.Students;
using MySchool.Services.Interfaces.Common;
using MySchool.Services.Interfaces.Services;
using MySchool.Services.ViewModels.Students;

namespace MySchool.Services.Service;

public class StudentService : BasicService, IStudentService
{
	public StudentService(IUnitOfWork repository, IFileService filer, IHasher hasher, IViewModelHelper viewModelHelper, IDtoHelper dtoHelper, IAuthManager authManager, IPaginatorService paginator) : base(repository, filer, hasher, viewModelHelper, dtoHelper, authManager, paginator)
	{

	}

	public async Task<bool> DeleteByIdAsync(long id)
	{
		//try
		//{
		_repository.Students.Delete(id);
		return await _repository.SaveChanges() > 0;
		//}
		//catch
		//{
		//	return false;
		//}
	}

	public async Task<bool> HireByIdAsync(long id)
	{
		var entity = await _repository.Students.FindByIdAsync(id);
		entity.Studying = false;
		return await _repository.SaveChanges() > 0;
	}

	public async Task<IEnumerable<StudentShortViewModel>> GetAllAsync(PaginationParams @params)
	{
		//try
		//{
		var page = await _paginator.ToPagedAsync(_repository.Students.GetAll().OrderByDescending(x => x.Acted), @params.PageNumber, @params.PageSize);
		return page.Select(x => _viewModelHelper.ToShort(x));
		//}
		//catch
		//{
		//	return Enumerable.Empty<StudentShortViewModel>();
		//}

	}

	public async Task<StudentFullViewModel> GetByIdAsync(long id)
	{
			Student? entity = await _repository.Students.FindByIdAsync(id);
			if(entity == null)
				throw new Exception();
			return _viewModelHelper.ToFull(entity);
		
	}

	public async Task<IEnumerable<StudentShortViewModel>> GetStudyingAsync(PaginationParams @params)
	{
		//try
		//{
		List<Student> page = await _repository.Students.Where(x => x.Studying).OrderByDescending(x => x.Acted).Skip((@params.PageNumber - 1) * @params.PageSize).Take(@params.PageSize).ToListAsync();
		return page.Select(x => _viewModelHelper.ToShort(x));
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
		Student? entity = _repository.Students.GetAll().FirstOrDefault(x => x.Id == dto.Id);

		if(entity == null)
			throw new Exception("student is null");
		string passwordhashed = _hasher.Hash(dto.Pin.ToString(), "");
		if(entity.Pin != passwordhashed)
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
		Student entity = await _dtoHelper.ToEntity(dto);
		string PinCode = entity.Pin;
		entity.Pin = _hasher.Hash(entity.Pin, "");
		_repository.Students.Add(entity);
		_ = await _repository.SaveChanges();
		long studentId = (await _repository.Students.GetAll().FirstAsync(x => x.Pin == entity.Pin)).Id;
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

	public async Task<IEnumerable<Student>> GetFullAsync(PaginationParams @params)
	{
		var page = await _paginator.ToPagedAsync(_repository.Students.GetAll().OrderByDescending(x => x.Acted), @params.PageNumber, @params.PageSize);
		return page.Select(x => x);
	}
}
