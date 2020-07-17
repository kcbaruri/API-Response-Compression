using System.Collections.Generic;

namespace CompressedWebAPIResponse.Models
{

    public class BaseResponse
	{
		public BaseResponse()
		{
			StatusCode = 0; // 0 = Success, 1..n = Erors Codes
			Message = "";
			MessageDetail = "";
			Errors = new List<string>();
		}

		public int StatusCode { get; set; }
		public string Message { get; set; }
		public string MessageDetail { get; set; }
		public List<string> Errors { get; set; }
	}

	public class BaseResponse<T>
	{
		public BaseResponse()
		{
			StatusCode = 0; // 0 = Success, 1..n = Erors Codes
			Message = "";
			MessageDetail = "";
			Errors = new List<string>();
		}

		public int StatusCode { get; set; }
		public string Message { get; set; }
		public string MessageDetail { get; set; }
		public List<string> Errors { get; set; }
		public T Data { get; set; }
	}
}