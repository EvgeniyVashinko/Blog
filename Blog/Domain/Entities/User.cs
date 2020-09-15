using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Domain.Entities
{
    public class User : IdentityUser<Guid>
    {
        public string ImagePath { get; set; }
        List<Article> Articles { get; set; }
        List<Comment> Comments { get; set; }

    }
}
