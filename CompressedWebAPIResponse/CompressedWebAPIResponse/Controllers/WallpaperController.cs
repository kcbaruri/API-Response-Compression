using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;
using CompressedWebAPIResponse.Models;

namespace K2BWallpaper.Api.Controllers
{
    [RoutePrefix("wallpaper")]
    public class WallpaperMobileController : ApiController
    {
        [HttpGet]
        [ResponseType(typeof(BaseResponse))]
        [Route("getcategory")]
        public IHttpActionResult GetWallpaperCategory()
        {
            List<CategoryInfo> categoryList = new List<CategoryInfo>();
            categoryList.Add(new CategoryInfo { Id = 1, CategoryName = "Category 1", Photo = "www.testdomain.com/photo/image1.jpg", Added = DateTime.Now });
            categoryList.Add(new CategoryInfo { Id = 2, CategoryName = "Category 2", Photo = "www.testdomain.com/photo/image2.jpg", Added = DateTime.Now });

            var response = new CategoryListResponse
            {
                Data = new CategoryListResponse.ResponseData
                {
                    CategoryList = categoryList,
                    SyncDateTime = DateTimeOffset.Parse(DateTime.Now.ToString()).UtcDateTime
                }
            };

            return Ok(response);
        }
    }
}