using CloudBlog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBlog.Lib.Entities.Concrete
{
    public class ArticleTag : IEntity
    {
        public int Id { get; set; }
        public int? ArticleId { get; set; }
        public int TagId { get; set; }
    }
}
