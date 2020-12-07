using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Services;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    [Authorize]
    public class ArticleController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly UserManager<User> userManager;
        public ArticleController(DataManager dataManager, IWebHostEnvironment webHostEnvironment, UserManager<User> userManager)
        {
            this.dataManager = dataManager;
            this.webHostEnvironment = webHostEnvironment;
            this.userManager = userManager;
        }
        public async Task<IActionResult> Report(string category, Guid id)
        {
            var cat = dataManager.ReportCategories.GetReportCategory(category);
            var user = await userManager.GetUserAsync(HttpContext.User);
            var article = dataManager.Articles.GetArticle(id);

            var rep = dataManager.Reports.GetReport(article.Id, cat.Id, user.Id);
            if (rep == null)
            {
                var report = new Report { Article = article, User = user, ReportCategory = cat };
                dataManager.Reports.SaveReport(report);
            }

            return RedirectToAction("Show", "Blog", new { id = id });
        }
    }
}
