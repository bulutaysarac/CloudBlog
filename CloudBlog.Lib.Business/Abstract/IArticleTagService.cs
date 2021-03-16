using CloudBlog.Lib.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBlog.Lib.Business.Abstract
{
    public interface IArticleTagService
    {
        void Add(ArticleTag articleTag);
        void Update(ArticleTag articleTag);
        void Delete(int articleTagId);
    }
}
