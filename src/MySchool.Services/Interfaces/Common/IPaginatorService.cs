namespace MySchool.Services.Interfaces.Common;

public interface IPaginatorService
{
	public Task<IList<T>> ToPagedAsync<T>(IQueryable<T> items, int pageNumber, int pageSize);
}
