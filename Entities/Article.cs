using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    public class Article : EntityBase
    {
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Заглавие")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Текст")]
        public string Text { get; set; }
        //[Required]
        [Display(Name = "Путь к изображению")]
        public string ImagePath { get; set; }
        public List<Comment> Comments { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public List<ArticleLike> ArticleLikes { get; set; }
        public List<Report> Reports { get; set; }
        public Guid CategotyId { get; set; }
        public Category Category { get; set; }
    }
}
