using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreShowCase.Api.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public DateTime DatePosted { get; set; }
        public bool Approved { get; set; }
        public string TheComment { get; set; }

        // Create relationship with BlogPost table
        public BlogPost BlogPost { get; set; }
        public int BlogId { get; set; }
    }
}
