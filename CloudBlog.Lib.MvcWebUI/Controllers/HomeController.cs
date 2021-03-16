using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CloudBlog.Lib.MvcWebUI.Models;
using CloudBlog.Lib.Business.Abstract;
using Microsoft.AspNetCore.Authorization;

namespace CloudBlog.Lib.MvcWebUI.Controllers
{
    public class HomeController : Controller
    {
        private IArticleService _articleService;

        public HomeController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IActionResult Index()
        {
            var model = new ArticleListViewModel()
            {
                Articles = _articleService.GetArticleAndCategory()
            };

            return View(model);
        }

        public IActionResult ArticleDetail(int articleId)
        {
            var model = new ArticleCategoryTagViewModel()
            {
                Article = _articleService.GetArticleCategoryTag(articleId)
            };

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
