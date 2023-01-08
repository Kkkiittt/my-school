using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

using MySchool.Services.Common.Utils;
using MySchool.Services.Interfaces.Common;

using Newtonsoft.Json;

namespace MySchool.Services.Service.Common;

public class PaginatorService : IPaginatorService
{
	private readonly IHttpContextAccessor _accessor;

	public PaginatorService(IHttpContextAccessor httpContextAccessor)
	{
		_accessor = httpContextAccessor;
	}
	public async Task<IList<T>> ToPagedAsync<T>(IQueryable<T> items, int pageNumber, int pageSize)
	{
		int totalitems = await items.CountAsync();


		PaginationMetaData paginationMetaData = new PaginationMetaData()
		{
			CurrentPage = pageNumber,
			PageSize = pageSize,
			TotalItems = totalitems,
			TotalPages = (int)Math.Ceiling(totalitems / (double)pageSize),
			HasPrevious = pageNumber > 0,
		};
		paginationMetaData.HasNext = paginationMetaData.CurrentPage < paginationMetaData.TotalPages;



		string json = JsonConvert.SerializeObject(paginationMetaData);

		_accessor.HttpContext.Response.Headers.Add("X-Pagination", json);

		return await items.Skip(pageNumber * pageSize - pageSize)
						  .Take(pageSize)
						  .ToListAsync();

	}
}
