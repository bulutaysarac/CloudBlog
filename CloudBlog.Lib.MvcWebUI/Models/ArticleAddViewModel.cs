using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudBlog.Lib.MvcWebUI.Models
{
    public class ArticleAddViewModel
    {
        public string Thumbnail { get; set; }
        public int CategoryId { get; set; }
        public string ArticleTitle { get; set; }
        public string ArticleContent { get; set; }
        public int Views { get; set; }
        public DateTime PublishDate { get; set; }
        public int AdminId { get; set; }
        public List<SelectListItem> Categories { get; set; }
        public string Description { get; set; }
    }
}
