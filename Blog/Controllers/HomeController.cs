using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;
        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View(dataManager.Articles.GetArticles());
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult CultureManagement(string culture, string returnUrl)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName, CookieRequestCultureProvider.MakeCookieValue(
                new RequestCulture(culture)), new CookieOptions { Expires = DateTimeOffset.Now.AddDays(30) });
            return Redirect(returnUrl ?? "/");
        }
    }
}
