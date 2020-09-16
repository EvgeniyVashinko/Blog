using Blog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Domain.Repositories.Abstract
{
    public interface ICommentRepository
    {
        IQueryable<Comment> GetComments();
        Comment GetComment(Guid id);
        IQueryable<Comment> GetArticlesByAuthor(User user);
        void SaveComment(Comment comment);
        void DeleteComment(Guid id);
    }
}
