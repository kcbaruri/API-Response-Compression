//using System;
//using System.Collections.Generic;

//namespace CompressedWebAPIResponse.Models
//{
//    public class WallpaperDetailsResponse : BaseResponse<WallpaperDetailsResponse.ResponseData>
//	{
//		public class ResponseData
//		{
//			public int Id { get; set; }
//			public string Name { get; set; }
//			public string CategoryName { get; set; }
//			public string Photo { get; set; }
//			public long ViewCount { get; set; }
//            public long DownloadCount { get; set; }
//            public DateTime Added { get; set; }

//		}
//	}

//	public class WallpaperListResponse : BaseResponse<IList<WallpaperListResponse.ResponseData>>
//	{
//		public class ResponseData
//		{
//			public int Id { get; set; }
//			public string Name { get; set; }
//			public string CategoryName { get; set; }
//			public string Photo { get; set; }
//			public long ViewCount { get; set; }
//            public long DownloadCount { get; set; }
//            public DateTime Added { get; set; }
//		}
//	}
//}