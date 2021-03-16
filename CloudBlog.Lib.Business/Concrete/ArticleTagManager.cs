using CloudBlog.Lib.Business.Abstract;
using CloudBlog.Lib.DataAccess.Abstract;
using CloudBlog.Lib.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBlog.Lib.Business.Concrete
{
    public class ArticleTagManager : IArticleTagService
    {
        private IArticleTagDal _articleTagDal;

        public ArticleTagManager(IArticleTagDal articleTagDal)
        {
            _articleTagDal = articleTagDal;
        }

        public void Add(ArticleTag articleTag)
        {
            _articleTagDal.Add(articleTag);
        }

        public void Delete(int articleTagId)
        {
            var articleTag = _articleTagDal.Get(i => i.Id == articleTagId);
            _articleTagDal.Delete(articleTag);
        }

        public void Update(ArticleTag articleTag)
        {
            _articleTagDal.Update(articleTag);
        }
    }
}
