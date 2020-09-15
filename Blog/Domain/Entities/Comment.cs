using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Domain.Entities
{
    public class Comment
    {
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Текст")]
        public string Text { get; set; }
        [HiddenInput(DisplayValue = false)]
        public int Like_amount { get; set; }

        public Guid ArticleID { get; set; }
        public Article Article { get; set; }

        public Guid UserID { get; set; }
        public User User { get; set; }
    }
}
