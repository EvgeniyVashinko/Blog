
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    public class Comment : EntityBase
    {
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Текст")]
        public string Text { get; set; }
        //[HiddenInput(DisplayValue = false)]
        //public int Like_amount { get; set; }//удалить

        public Guid ArticleID { get; set; }
        public Article Article { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
    }
}
