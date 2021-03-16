using CloudBlog.Lib.Business.Abstract;
using CloudBlog.Lib.DataAccess.Abstract;
using CloudBlog.Lib.Entities.ComplexTypes;
using CloudBlog.Lib.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBlog.Lib.Business.Concrete
{
    public class ArticleManager : IArticleService
    {
        private IArticleDal _articleDal;

        public ArticleManager(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }

        public List<ArticleCategoryComplexData> GetArticleAndCategory()
        {
            return _articleDal.GetArticleAndCategory();
        }

        public ArticleCategoryTagComplexData GetArticleCategoryTag(int articleId)
        {
            return _articleDal.GetArticleCategoryTag(articleId);
        }

        public void Add(Article article)
        {
            _articleDal.Add(article);
        }

        public void Delete(int articleId)
        {
            var article = _articleDal.Get(i => i.Id == articleId);
            _articleDal.Delete(article);
        }

        public void Update(Article article)
        {
            _articleDal.Update(article);
        }
    }
}
