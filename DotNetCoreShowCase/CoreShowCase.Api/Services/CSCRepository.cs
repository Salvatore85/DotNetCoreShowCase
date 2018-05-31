using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreShowCase.Api.Entities;

namespace CoreShowCase.Api.Services
{
    public class CSCRepository : ICSCRepository
    {
        private CoreShowCaseContext Context;

        public CSCRepository(CoreShowCaseContext context)
        {
            Context = context;
        }

        public BlogPost GetBlogPost(int blogPostId)
        {
            return Context.BlogPosts.Where(b => b.Id == blogPostId).FirstOrDefault();
        }

        public IEnumerable<BlogPost> GetBlogPosts()
        {
            return Context.BlogPosts.OrderBy(o => o.DatePosted);
        }

        public Comment GetComment(int commentId)
        {
            return Context.Comments.Where(c => c.Id == commentId).FirstOrDefault();
        }

        public IEnumerable<Comment> GetComments()
        {
            return Context.Comments.OrderBy(o => o.DatePosted);
        }

        public User GetUser(int userId)
        {
            return Context.Users.Where(u => u.Id == userId).FirstOrDefault();
        }

        public IEnumerable<User> GetUsers()
        {
            return Context.Users.ToList();
        }

        public bool UserExists(int userId)
        {
            return Context.Users.Any(u => u.Id == userId);
        }
    }
}
