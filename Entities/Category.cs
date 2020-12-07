using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    public class Category
    {
        public string Name { get; set; }
        public string BeName { get; set; }
        public string EnName { get; set; }
        public Guid Id { get; set; }
        public List<Article> Articles { get; set; }
    }
}
