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
    public class EFCommentRepository : ICommentRepository
    {
        private readonly AppDbContext context;
        public EFCommentRepository(AppDbContext context)
        {
            this.context = context;
        }
        public void DeleteComment(Guid id)
        {
            context.Comments.Remove(new Comment() { Id = id });
            context.SaveChanges();
        }

        public IQueryable<Comment> GetCommentsByAuthor(User user) 
        {
            return context.Comments.Where(x => x.User.Id == user.Id);
        }
        public IQueryable<Comment> GetCommentsByArticle(Article article)
        {
            return context.Comments.Where(x => x.Article.Id == article.Id);
        }

        public Comment GetComment(Guid id)
        {
            return context.Comments.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<Comment> GetComments()
        {
            return context.Comments;
        }

        public void SaveComment(Comment comment)
        {
            if (comment.Id == default)
            {
                context.Entry(comment).State = EntityState.Added;
            }
            else
            {
                context.Entry(comment).State = EntityState.Modified;
            }
            context.SaveChanges();
        }
    }
}
