using System;

namespace CompressedWebAPIResponse.Models
{
    public class CategoryInfo
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Photo { get; set; }
        public int WallpaperCount { get; set; }
        public DateTime Added { get; set; }
    }
}