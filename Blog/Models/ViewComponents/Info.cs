using Services;
using Entities;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models.ViewComponents
{
    public class Info : ViewComponent
    {
        private readonly DataManager dataManager;
        private readonly UserManager<User> userManager;
        public Info(DataManager dataManager, UserManager<User> userManager)
        {
            this.dataManager = dataManager;
            this.userManager = userManager;
        }
        public IViewComponentResult Invoke()
        {
            var articlesCount = dataManager.Articles.GetArticles().Count();
            var commentsCount = dataManager.Comments.GetComments().Count();
            var usersCount = userManager.Users.Count();
            Information info = new Information(articlesCount, commentsCount, usersCount);
            return View("Info", info);
        }
    }
    public class Information
    {
        public int ArticlesCount { get; set; }
        public int CommentsCount { get; set; }
        public int UsersCount { get; set; }
        public Information(int articlesCount, int commentsCount, int usersCount)
        {
            this.ArticlesCount = articlesCount;
            this.CommentsCount = commentsCount;
            this.UsersCount = usersCount;
        }

    }
}
