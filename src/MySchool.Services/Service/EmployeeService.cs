using System.Net;

using Microsoft.EntityFrameworkCore;

using My_School.Domain.Entities.Employees;

using MySchool.DataAccess.Interfaces;
using MySchool.Services.Common.Exceptions;
using MySchool.Services.Common.Utils;
using MySchool.Services.Dtos.Employees;
using MySchool.Services.Interfaces.Common;
using MySchool.Services.Interfaces.Services;
using MySchool.Services.ViewModels.Employees;

namespace MySchool.Services.Service;

public class EmployeeService : BasicService, IEmployeeService
{
	public EmployeeService(IUnitOfWork repository, IFileService filer, IHasher hasher, IViewModelHelper viewModelHelper, IDtoHelper dtoHelper, IAuthManager authManager, IPaginatorService paginator) : base(repository, filer, hasher, viewModelHelper, dtoHelper, authManager, paginator)
	{

	}

	public async Task<bool> DeleteByIdAsync(long id)
	{
		//try
		//{
		_repository.Employees.Delete(id);
		return await _repository.SaveChanges() > 0;
		//}
		//catch
		//{
		//	return false;
		//}
	}

	public async Task<IEnumerable<EmployeeShortViewModel>> GetAll(PaginationParams @params)
	{
		var page = await _paginator.ToPagedAsync(_repository.Employees.GetAll(), @params.PageNumber, @params.PageSize);
		return page.Select(x => _viewModelHelper.ToShort(x));
	}

	public async Task<string> LoginAsync(EmployeeLoginDto dto)
	{
		Employee? employee = await _repository.Employees.FirstOrDefaultAsync(x => x.Email == dto.Email);
		if(employee is null)
			throw new StatusCodeException(HttpStatusCode.NotFound, "Employee not found, Phone Number is incorrect!");
		if(!employee.EmailVerified)
			throw new StatusCodeException(HttpStatusCode.BadRequest, "Email not verified");
		bool hashResult = _hasher.Verify(employee.Password, dto.Password, employee.Email);
		if(hashResult)
		{
			return _authManager.GenerateToken(employee);
		}
		else
			throw new StatusCodeException(HttpStatusCode.BadRequest, "Password is invalid!");
	}

	public async Task<bool> MakeAuthor(long id)
	{
		//try
		//{
		Employee? entity = await _repository.Employees.FindByIdAsync(id);
		entity.Role = My_School.Domain.Enums.Role.Author;
		_repository.Employees.Update(entity);
		return await _repository.SaveChanges() > 0;
		//}
		//catch
		//{
		//	throw new Exception("Command failed");
		//}

	}

	public async Task<bool> RegisterAsync(EmployeeRegisterDto dto)
	{
		//try
		//{
		if(_repository.Employees.GetAll().Any(x => x.Email == dto.Email))
		{
			throw new Exception();
		}
		Employee entity = await _dtoHelper.ToEntity(dto);
		_repository.Employees.Add(entity);
		return await _repository.SaveChanges() > 0;
		//}
		//catch
		//{
		//	return false;
		//}
	}
}
