namespace MySchool.Services.Common.Utils;

public class PaginationParams
{
	public PaginationParams(int pageNumber, int pageSize)
	{
		PageNumber = pageNumber;
		PageSize = pageSize;
	}

	public int PageNumber { get; set; }

	public int PageSize { get; set; }

}
