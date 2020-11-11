using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Blog.Domain;
using Blog.Domain.Entities;
using Blog.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly UserManager<User> userManager;
        public HomeController(DataManager dataManager, IWebHostEnvironment webHostEnvironment, UserManager<User> userManager)
        {
            this.dataManager = dataManager;
            this.webHostEnvironment = webHostEnvironment;
            this.userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Users()
        {
            return View(userManager.Users);
        }
        public IActionResult Articles(string id)
        {
            IQueryable<Article> articles;
            if (id == null)
            {
                articles = dataManager.Articles.GetArticles();
            }
            else
            {
                articles = dataManager.Articles.GetArticlesByUser(id);
            }
            return View(articles);
        }
        public IActionResult Reports()
        {
            return View(dataManager.Reports.GetReports());
        }
        public IActionResult EditArticle(Guid articleId)
        {
            var article = dataManager.Articles.GetArticle(articleId);

            return View(article);
        }
        [HttpPost]
        public IActionResult EditArticle(Article model, IFormFile imgFile, string category, string userId)
        {
            if (ModelState.IsValid)
            {
                Category cat = dataManager.Categories.GetCategory(category);
                //model.UserId = userId;
                model.Category = cat;
                if (imgFile != null)
                {
                    model.ImagePath = imgFile.FileName;
                    using (var stream = new FileStream(Path.Combine(webHostEnvironment.WebRootPath, "images/", imgFile.FileName), FileMode.Create))
                    {
                        imgFile.CopyTo(stream);
                    }
                }
                dataManager.Articles.SaveArticle(model);
                return View("Articles", dataManager.Articles.GetArticlesByUser(model.UserId));
            }
            return View(model);
        }
        public IActionResult DeleteArticle(Guid articleId)
        {
            dataManager.Articles.DeleteArticle(articleId);
            return View("Articles", dataManager.Articles.GetArticles());
        }
        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            await userManager.DeleteAsync(user);
            return RedirectToAction("Users");
        }
        public IActionResult DeleteReport(Guid articleId, Guid categoryId, string userId)
        {
            dataManager.Reports.DeleteReport(articleId, categoryId, userId);
            return RedirectToAction("Reports");
        }
        public IActionResult ReportCategories()
        {
            return View(dataManager.ReportCategories.GetReportCategories());
        }
        public IActionResult ArticleCategories()
        {
            return View(dataManager.Categories.GetCategories());
        }
        public IActionResult EditReportCategory(Guid id)
        {
            var category = id == default ? new ReportCategory() : dataManager.ReportCategories.GetReportCategory(id);
            return View(category);
        }
        [HttpPost]
        public IActionResult EditReportCategory(ReportCategory model)
        {
            if (ModelState.IsValid)
            {
                dataManager.ReportCategories.SaveReportCategory(model);
                return RedirectToAction("ReportCategories");
            }
            return View(model);
        }
        public IActionResult DeleteReportCategory(Guid id)
        {
            dataManager.ReportCategories.DeleteReportCategory(id);
            return RedirectToAction("ReportCategories");
        }
        public IActionResult EditArticleCategory(Guid id)
        {
            var category = id == default ? new Category() : dataManager.Categories.GetCategory(id);
            return View(category);
        }
        [HttpPost]
        public IActionResult EditArticleCategory(Category model)
        {
            if (ModelState.IsValid)
            {
                dataManager.Categories.SaveCategory(model);
                return RedirectToAction("ArticleCategories");
            }
            return View(model);
        }
        public IActionResult DeleteArticleCategory(Guid id)
        {
            dataManager.Categories.DeleteCategory(id);
            return RedirectToAction("ArticleCategories");
        }
        [Authorize(Roles ="superadmin")]
        public async Task<IActionResult> ChangeUserRole(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            if (userManager.IsInRoleAsync(user, "admin").Result)
            {
                await userManager.RemoveFromRoleAsync(user, "admin");
            }
            else
            {
                await userManager.AddToRoleAsync(user, "admin");
            }
            //await userManager.DeleteAsync(user);
            return RedirectToAction("Users");
        }

        [HttpPost]
        public IActionResult CultureManagement(string culture, string returnUrl)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName, CookieRequestCultureProvider.MakeCookieValue(
                new RequestCulture(culture)), new CookieOptions { Expires = DateTimeOffset.Now.AddDays(30) });
            return Redirect(returnUrl ?? "/");
        }
    }
}
