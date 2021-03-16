using CloudBlog.Core.DataAccess.EntityFramework;
using CloudBlog.Lib.DataAccess.Abstract;
using CloudBlog.Lib.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBlog.Lib.DataAccess.Concrete.EntityFramework
{
    public class EfArticleTagDal : EfEntityRepositoryBase<ArticleTag, CloudBlogContext>, IArticleTagDal
    {

    }
}
