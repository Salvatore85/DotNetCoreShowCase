using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreShowCase.Api.Models
{
    public class BlogPostCreationDTO
    {
        public DateTime DatePosted { get; set; }
        public string Title { get; set; }
        public string Article { get; set; }
    }
}
