using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Blog.Domain;
using Blog.Domain.Entities;
using Blog.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
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
    }
}
