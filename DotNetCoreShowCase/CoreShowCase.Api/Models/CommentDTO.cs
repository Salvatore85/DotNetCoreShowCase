using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreShowCase.Api.Models
{
    public class CommentDTO
    {
        public int Id { get; set; }
        public DateTime DatePosted { get; set; }
        public bool Approved { get; set; }
        public string TheComment { get; set; }
    }
}
