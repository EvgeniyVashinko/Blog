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
        public DateTime date { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "p";
            var tagStart = "<small class=\"date-output\">";
            var tagEnd = "</small>";
            var res = tagStart + date.ToString("HH:mm:ss dd.MM.yyyy") + tagEnd;
            output.Content.SetHtmlContent(res);
        }
    }
}
