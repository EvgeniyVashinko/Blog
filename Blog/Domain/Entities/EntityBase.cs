using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Domain.Entities
{
    public abstract class EntityBase
    {
        [Required]
        public Guid Id { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime PublishDate { get; set; }

        protected EntityBase() => PublishDate = DateTime.Now;
    }
}
