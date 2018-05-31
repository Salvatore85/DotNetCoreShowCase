using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreShowCase.Api.Models
{
    public class BlogPostDTO
    {
        public int Id { get; set; }
        public DateTime DatePosted { get; set; }
        public string Title { get; set; }
        public string Article { get; set; }

        public ICollection<CommentDTO> Comments { get; set; } = new List<CommentDTO>();

        public bool HasComments
        {
            get
            {
                return Comments.Any();
            }
        }

        public int NumberOfComments
        {
            get
            {
                return Comments.Count;
            }
        }
    }
}
