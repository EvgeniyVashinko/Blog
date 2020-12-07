using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface ICommentRepository
    {
        IQueryable<Comment> GetComments();
        Comment GetComment(Guid id);
        IQueryable<Comment> GetCommentsByAuthor(User user);
        IQueryable<Comment> GetCommentsByArticle(Article article);
        void SaveComment(Comment comment);
        void DeleteComment(Guid id);
    }
}
