using CloudBlog.Lib.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBlog.Lib.Entities.ComplexTypes
{
    public class ArticleCategoryTagComplexData
    {
        public ArticleCategoryComplexData ArticleAndCategory { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
