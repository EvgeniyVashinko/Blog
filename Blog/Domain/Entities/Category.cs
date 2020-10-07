using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Domain.Entities
{
    public class Category
    {
        public Guid Id { get; set; }
        public List<Article> Articles { get; set; }
    }
}
