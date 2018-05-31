using CoreShowCase.Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreShowCase.Api.Services
{
    public interface ICSCRepository
    {
        IEnumerable<User> GetUsers();
        User GetUser(int userId);
        void CreateUser(User user);
        bool UserExists(int userId);

        IEnumerable<BlogPost> GetBlogPosts();
        BlogPost GetBlogPost(int blogPostId);

        IEnumerable<Comment> GetComments();
        Comment GetComment(int commentId);

        bool Save();
    }
}
