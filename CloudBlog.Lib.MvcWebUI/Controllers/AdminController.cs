using System;
using System.Collections.Generic;
using System.Linq;
using CloudBlog.Lib.Business.Abstract;
using CloudBlog.Lib.Entities.Concrete;
using CloudBlog.Lib.MvcWebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CloudBlog.Lib.MvcWebUI.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly ICategoryService _categoryService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AdminController(IArticleService articleService, ICategoryService categoryService, IHttpContextAccessor httpContextAccessor)
        {
            _articleService = articleService;
            _categoryService = categoryService;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListArticles()
        {
            var result = _articleService.GetArticleAndCategory();
            return View(result);
        }

        public JsonResult DeleteArticle(int articleId)
        {
            _articleService.Delete(articleId);
            return Json(0);
        }

        public IActionResult AddArticle()
        {
            var model = new ArticleAddViewModel() { Categories = LoadCategories() };
            return View(model);
        }

        [HttpPost]
        public IActionResult AddArticle(ArticleAddViewModel model)
        {
            var article = new Article()
            {
                ArticleContent = model.ArticleContent,
                AdminId = (int)_httpContextAccessor.HttpContext.Session.GetInt32("userid"),
                ArticleTitle = model.ArticleTitle,
                CategoryId = model.CategoryId,
                PublishDate = DateTime.Now,
                Thumbnail = model.Thumbnail,
                Views = model.Views,
                Description = model.Description
            };

            _articleService.Add(article);
            ViewData["Message"] = "Record has been added successfully!";

            var model2 = new ArticleAddViewModel() { Categories = LoadCategories() };
            return View(model2);
        }

        public List<SelectListItem> LoadCategories()
        {
            var categories = (from category in _categoryService.GetAll()
                              select new SelectListItem() { Value = category.Id.ToString(), Text = category.Name }).ToList();

            return categories;
        }
    }
}
