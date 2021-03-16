using CloudBlog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBlog.Lib.Entities.Concrete
{
    public class Article : IEntity
    {
        public int Id { get; set; }
        public string Thumbnail { get; set; }
        public int CategoryId { get; set; }
        public string ArticleTitle { get; set; }
        public string ArticleContent { get; set; }
        public int Views { get; set; }
        public DateTime PublishDate { get; set; }
        public int AdminId { get; set; }
        public string Description { get; set; }
    }
}
