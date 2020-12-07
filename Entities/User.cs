using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    public class User : IdentityUser
    {
        //public string ImagePath { get; set; } //удалить
        public List<Article> Articles { get; set; }
        public List<Comment> Comments { get; set; }
        public Profile Profile { get; set; }
        public List<ArticleLike> ArticleLikes { get; set; }
        public List<Report> Reports { get; set; }

    }
}
