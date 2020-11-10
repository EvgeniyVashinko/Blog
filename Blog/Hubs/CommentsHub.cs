using Blog.Domain.Entities;
using Blog.Domain.Repositories.Abstract;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Hubs
{
    public class CommentsHub : Hub
    {
        private readonly ICommentRepository commentRepository;
        private readonly UserManager<User> _userManager;

        public CommentsHub(ICommentRepository commentService, UserManager<User> userManager)
        {
            commentRepository = commentService;
            _userManager = userManager;
        }

        public async Task AddToGroup(string groupName)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
        }

        public async Task RemoveFromGroup(string groupName)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, groupName);
        }

        public async Task SendComment(string articleId, string content)
        {
            var user = await _userManager.GetUserAsync(Context.User);

            Comment comment = new Comment
            {
                ArticleID = Guid.Parse(articleId),
                User = user,
                Text = content
            };

            commentRepository.SaveComment(comment);

            await Clients.Group(articleId).SendAsync("Send", user.UserName, comment.Text, comment.PublishDate);
        }
    }
}
