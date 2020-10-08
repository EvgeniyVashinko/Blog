using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Domain.Entities
{
    public class ReportCategory
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Report> Reports { get; set; }
    }
}
