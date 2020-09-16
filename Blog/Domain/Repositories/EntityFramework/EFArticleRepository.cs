using Blog.Domain.Entities;
using Blog.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Blog.Domain.Repositories.EntityFramework
{
    public class EFArticleRepository : IArticleRepository
    {
        private readonly AppDbContext context;
        public EFArticleRepository(AppDbContext context)
        {
            this.context = context;
        }

        public Article GetArticle(Guid id)
        {
            return context.Articles.FirstOrDefault(x => x.Id == id);
        }
        public IQueryable<Article> GetArticlesByUser(User user)
        {
            return context.Articles.Where(x => x.User.Equals(user));
        }

        public IQueryable<Article> GetArticles()
        {
            return context.Articles;
        }

        public void SaveArticle(Article article)
        {
            if (article.Id == default)
            {
                context.Entry(article).State = EntityState.Added;
            }
            else
            {
                context.Entry(article).State = EntityState.Modified;
            }
            context.SaveChanges();
        }

        public void DeleteArticle(Guid id)
        {
            context.Articles.Remove(new Article() { Id = id });
            context.SaveChanges();
        }


    }
}
