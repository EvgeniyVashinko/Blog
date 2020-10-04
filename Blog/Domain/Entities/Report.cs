using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Domain.Entities
{
    public class Report : EntityBase 
    {
        [Required]
        public string Text { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public Guid ArticleId { get; set; }
        public Article Article { get; set; }
    }
}
