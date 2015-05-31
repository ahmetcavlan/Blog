using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class Post
    {
        [Key]
        public int post_Id { get; set; }  
        public string post_Content { get; set; }
        public string post_Title { get; set; }
        public string created_By { get; set; }
        public DateTime post_Date { get; set; }
        public string post_preview { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<ImagePath> ImagePaths { get; set; }

    }
    public class Image
    {
        [Key]
        public int Image_Id { get; set; }
        [StringLength(255)]
        public string Image_Name { get; set; }
        [StringLength(100)]
        public string Content_Type { get; set; }
        public byte[] Content { get; set; }
        public ImageType Image_Type { get; set; }
        public int post_Id { get; set; }
        public virtual Post post { get; set; }
    }
    public class ImagePath
    {
        [Key]
        public int ImagePath_Id { get; set; }
        [StringLength(255)]
        public string Image_Name { get; set; }
        public ImageType Image_Type { get; set; }
        public int post_Id { get; set; }
        public virtual Post post { get; set; }
    }
    public enum ImageType
    {
        Avatar = 1, Photo
    }
}