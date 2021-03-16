using CloudBlog.Lib.Entities.ComplexTypes;
using CloudBlog.Lib.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBlog.Lib.Business.Abstract
{
    public interface IArticleService
    {
        List<ArticleCategoryComplexData> GetArticleAndCategory();

        ArticleCategoryTagComplexData GetArticleCategoryTag(int articleId);

        void Add(Article article);
        void Delete(int articleId);
        void Update(Article article);
    }
}
