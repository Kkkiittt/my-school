using System.Net;

namespace MySchool.Services.Common.Exceptions;

public class StatusCodeException : Exception
{
	public HttpStatusCode StatusCode { get; set; }

	public StatusCodeException(HttpStatusCode statusCode, string message)
		: base(message)
	{
		StatusCode = statusCode;
	}
}
