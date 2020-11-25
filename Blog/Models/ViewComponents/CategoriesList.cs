using Blog.Domain;
using Blog.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models.ViewComponents
{
    public class CategoriesList : ViewComponent
    {
        public IViewComponentResult Invoke(IEnumerable<string> list=null, bool select = false, string contr = "", string actn = "", string id="")
        {
            ViewBag.contr = contr;
            ViewBag.actn = actn;
            ViewBag.aid = id;
            if (select)
            {
                return View("Select", list);
            }
            else
            {
                return View("List", list);
            }
        }
    }
}
