using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models.ViewComponents
{
    public class Date : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            DateTime date = DateTime.Now;
            return new HtmlContentViewComponentResult(
                new HtmlString($"<ul>{date.ToString("dd.MM.yyyy")}, {date.DayOfWeek}</ul>"));
        }
    }
}
