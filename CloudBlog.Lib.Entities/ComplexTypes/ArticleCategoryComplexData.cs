using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBlog.Lib.Entities.ComplexTypes
{
    public class ArticleCategoryComplexData
    {
        public int Id { get; set; }
        public string Thumbnail { get; set; }
        public string CategoryName { get; set; }
        public string ArticleTitle { get; set; }
        public string ArticleContent { get; set; }
        public int Views { get; set; }
        public DateTime PublishDate { get; set; }
        public string Description { get; set; }
    }
}
