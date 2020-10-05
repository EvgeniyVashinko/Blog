using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Domain;
using Blog.Domain.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
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

    }
}
