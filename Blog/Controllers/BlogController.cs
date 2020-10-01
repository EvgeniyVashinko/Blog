using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Blog.Domain;
using Blog.Domain.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class BlogController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly UserManager<User> userManager;
        public BlogController(DataManager dataManager, IWebHostEnvironment webHostEnvironment, UserManager<User> userManager)
        {
            this.dataManager = dataManager;
            this.webHostEnvironment = webHostEnvironment;
            this.userManager = userManager;
        }
        public IActionResult Edit(Guid id)
        {
            ViewBag.Head = "Новый пост";
            var article = id == default ? new Article() : dataManager.Articles.GetArticle(id);
            return View(article);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Article model, IFormFile imgFile)
        {
            if (ModelState.IsValid)
            {
                model.User = await userManager.GetUserAsync(HttpContext.User);

                if (imgFile != null)
                {
                    model.ImagePath = imgFile.FileName;
                    using(var stream = new FileStream(Path.Combine(webHostEnvironment.WebRootPath, "images/", imgFile.FileName), FileMode.Create))
                    {
                        imgFile.CopyTo(stream);
                    }
                }
                dataManager.Articles.SaveArticle(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).Replace("Controller", ""));
            }
            return View(model);
        }

        //[HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.Articles.DeleteArticle(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).Replace("Controller", ""));
        }

        public async Task<IActionResult> UserArticles()
        {
            var user = await userManager.GetUserAsync(HttpContext.User);
            return View(dataManager.Articles.GetArticlesByUser(user));
        }

        public async Task<IActionResult> EditArticles()
        {
            var user = await userManager.GetUserAsync(HttpContext.User);
            return View(dataManager.Articles.GetArticlesByUser(user));
        }

        public IActionResult FreshArticles()
        {
            var articles = from article in dataManager.Articles.GetArticles()
                           where article.PublishDate >= DateTime.Now.AddDays(-7)
                           orderby article.PublishDate descending
                           select article;
            return View(articles);
        }

        //Добавить лайки к записям и выбирать по наиболее популярным
        //public IActionResult PopularArticles() 
        //{
        //    var articles = from article in dataManager.Articles.GetArticles()
        //                   orderby article.Li
        //                   select article;
        //    return View(dataManager.Articles.GetArticles());
        //}
        public IActionResult Show(Guid id)
        {
            var article = dataManager.Articles.GetArticle(id);

            var comments = dataManager.Comments.GetCommentsByArticle(dataManager.Articles.GetArticle(id));
            ViewBag.Comments = comments;
            return View(article);
        }

        [HttpPost]
        public async Task<IActionResult> CreateComment(string tarea, Guid id)
        {
            Comment comment = new Comment();
            var user = await userManager.GetUserAsync(HttpContext.User);
            comment.Article = dataManager.Articles.GetArticle(id);
            comment.User = user;
            comment.Text = tarea;
            dataManager.Comments.SaveComment(comment);

            var comments = dataManager.Comments.GetCommentsByArticle(comment.Article);

            ViewBag.Comments = comments;
            return View("Show", dataManager.Articles.GetArticle(id));
        }
    }
}
