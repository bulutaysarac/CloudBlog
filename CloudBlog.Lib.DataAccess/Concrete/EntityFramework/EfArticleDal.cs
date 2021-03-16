using CloudBlog.Core.DataAccess.EntityFramework;
using CloudBlog.Lib.DataAccess.Abstract;
using CloudBlog.Lib.Entities.ComplexTypes;
using CloudBlog.Lib.Entities.Concrete;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace CloudBlog.Lib.DataAccess.Concrete.EntityFramework
{
    public class EfArticleDal : EfEntityRepositoryBase<Article, CloudBlogContext>, IArticleDal
    {
        public List<ArticleCategoryComplexData> GetArticleAndCategory()
        {
            using (var _context = new CloudBlogContext())
            {
                var model = from a in _context.Articles
                            join c in _context.Categories on a.CategoryId equals c.Id
                            select new ArticleCategoryComplexData
                            {
                                Id = a.Id,
                                ArticleContent = a.ArticleContent,
                                ArticleTitle = a.ArticleTitle,
                                CategoryName = c.Name,
                                PublishDate = a.PublishDate,
                                Thumbnail = a.Thumbnail,
                                Views = a.Views,
                                Description = a.Description
                            };

                return model.ToList();
            }
        }

        public ArticleCategoryTagComplexData GetArticleCategoryTag(int articleId)
        {
            using (var _context = new CloudBlogContext())
            {
                var article = from a in _context.Articles
                              join c in _context.Categories on a.CategoryId equals c.Id
                              where a.Id == articleId
                              select new ArticleCategoryComplexData
                              {
                                  Id = a.Id,
                                  ArticleContent = a.ArticleContent,
                                  ArticleTitle = a.ArticleTitle,
                                  CategoryName = c.Name,
                                  PublishDate = a.PublishDate,
                                  Thumbnail = a.Thumbnail,
                                  Views = a.Views,
                                  Description = a.Description
                            };

                var tags = from t in _context.Tags
                           join a in _context.ArticleTags on t.Id equals a.TagId
                           where a.ArticleId == articleId
                           select t;

                var model = new ArticleCategoryTagComplexData
                {
                    ArticleAndCategory = article.FirstOrDefault(),
                    Tags = tags.ToList()
                };

                return model;
            }
        }
    }
}
