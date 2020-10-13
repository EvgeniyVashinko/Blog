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
            context.Articles.Include(a => a.ArticleLikes).ToList();
            return context.Articles.FirstOrDefault(x => x.Id == id);
        }
        public IQueryable<Article> GetArticlesByUser(User user)
        {
            context.Articles.Include(a => a.ArticleLikes).ToList();
            return context.Articles.Where(x => x.User.Equals(user));
        }
        public IQueryable<Article> GetArticlesByUser(string id)
        {
            context.Articles.Include(a => a.ArticleLikes).ToList();
            return context.Articles.Where(x => x.UserId == id);
        }

        public IQueryable<Article> GetArticles()
        {
            context.Articles.Include(a => a.ArticleLikes).ToList();
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

        public void AddLike(User user, Article article)
        {
            context.Articles.Include(a => a.ArticleLikes).ToList();
            article.ArticleLikes.Add(new ArticleLike { UserId = user.Id, ArticleId = article.Id });
            context.SaveChanges();
        }
        public void DeleteLike(User user, Article article)
        {
            //context.ArticleLikes.Remove(new ArticleLike { User = user, Article = article });
            article.ArticleLikes.Remove(article.ArticleLikes.First(al => al.ArticleId == article.Id && al.UserId == user.Id));
            context.SaveChanges();
        }
        public bool IsLike(User user, Article article)
        {
            return context.ArticleLikes.Where(al => al.ArticleId == article.Id && al.UserId == user.Id).Count() != 0;
        }
        public int LikeAmount(Article article)
        {
            return context.ArticleLikes.Where(al => al.ArticleId == article.Id).Count();
        }
    }
}
