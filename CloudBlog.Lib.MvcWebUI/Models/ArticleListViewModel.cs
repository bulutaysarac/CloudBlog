using CloudBlog.Lib.Entities.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudBlog.Lib.MvcWebUI.Models
{
    public class ArticleListViewModel
    {
        public IEnumerable<ArticleCategoryComplexData> Articles { get; set; }
    }
}
