using Blog.Models.ViewComponents;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models.TagHelpers
{
    public class DateTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "ul";
            DateTime date = DateTime.Now;
            var res = $"{date.ToString("dd.MM.yyyy")}, {date.DayOfWeek}";
            output.Content.SetHtmlContent(res);
        }
    }
}
