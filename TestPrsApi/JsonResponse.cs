using System;
namespace TestPrsApi
{
	public class JsonResponse
	{
		public int HttpStatusCode { get; set; }

		public object? DataReturned { get; set; }
	}
}