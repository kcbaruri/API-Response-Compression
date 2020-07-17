using System;
using System.Collections.Generic;

namespace CompressedWebAPIResponse.Models
{
    public class CategoryListResponse : BaseResponse<CategoryListResponse.ResponseData>
    {
        public class ResponseData
        {
            public List<CategoryInfo> CategoryList { get; set; }
            public DateTime SyncDateTime { get; set; }
        }
    }
}