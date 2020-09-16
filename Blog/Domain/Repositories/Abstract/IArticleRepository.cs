using Blog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Domain.Repositories.Abstract
{
    public interface IArticleRepository
    {
        IQueryable<Article> GetArticles();
        IQueryable<Article> GetArticlesByUser(User user);
        Article GetArticle(Guid id);
        //IQueryable<Article> GetArticlesByTitle();
        void SaveArticle(Article article);
        void DeleteArticle(Guid id);
        
    }
}
