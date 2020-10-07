using Blog.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Domain
{
    public class DataManager
    {
        public IArticleRepository Articles { get; set; }
        public ICommentRepository Comments { get; set; }
        public ICategoryRepository Categories { get; set; }

        public DataManager(IArticleRepository articleRepository, ICommentRepository commentRepository, ICategoryRepository categoryRepository)
        {
            Articles = articleRepository;
            Comments = commentRepository;
            Categories = categoryRepository;
        }
    }
}
