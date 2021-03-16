using CloudBlog.Core.DataAccess;
using CloudBlog.Lib.Entities.ComplexTypes;
using CloudBlog.Lib.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBlog.Lib.DataAccess.Abstract
{
    public interface IArticleDal : IEntityRepository<Article>
    {
        ArticleCategoryTagComplexData GetArticleCategoryTag(int articleId);
        List<ArticleCategoryComplexData> GetArticleAndCategory();
    }
}
