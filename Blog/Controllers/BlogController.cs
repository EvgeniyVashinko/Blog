using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Blog.Domain;
using Blog.Domain.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class BlogController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment webHostEnvironment;
        public BlogController(DataManager dataManager, IWebHostEnvironment webHostEnvironment)
        {
            this.dataManager = dataManager;
            this.webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Edit(Guid id)
        {
            var article = id == default ? new Article() : dataManager.Articles.GetArticle(id);
            return View(article);
        }
        [HttpPost]
        public IActionResult Edit(Article model, IFormFile imgFile)
        {
            if (ModelState.IsValid)
            {
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

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.Articles.DeleteArticle(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).Replace("Controller", ""));
        }
    }
}
