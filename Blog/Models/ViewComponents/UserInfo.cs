using Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models.ViewComponents
{
    public class UserInfo : ViewComponent
    {
        private readonly UserManager<User> userManager;
        public UserInfo(UserManager<User> userManager)
        {
            this.userManager = userManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await userManager.GetUserAsync(HttpContext.User);
            return View("UserView", user);
        }
    }
}
