using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CloudBlog.Lib.Business.Abstract;
using CloudBlog.Lib.Entities.Concrete;
using CloudBlog.Lib.MvcWebUI.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CloudBlog.Lib.MvcWebUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly IAdminService _adminService;
        private IHttpContextAccessor _httpContextAccessor;
        public LoginController(IAdminService adminService, IHttpContextAccessor httpContextAccessor)
        {
            _adminService = adminService;
            _httpContextAccessor = httpContextAccessor;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserForLoginViewModel user)
        {
            var result = _adminService.Login(new Admin() { Username = user.Username, Password = user.Password });

            if (result != null)
            {
                var claims = new List<Claim>
                {
                    new Claim("Name", user.Username)
                };
                var userIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                _httpContextAccessor.HttpContext.Session.SetString("username", result.Username);
                _httpContextAccessor.HttpContext.Session.SetInt32("userid", result.Id);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                ViewData["mesaj"] = "";
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                ViewData["mesaj"] = "Kullanıcı Adı veya Parola Hatalı !";
            }

            return View();
        }

        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index");
        }
    }
}
