using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreShowCase.Api.Models
{
    public class CommentCreationDTO
    {
        public DateTime DatePosted { get; set; }
        public bool Approved { get; set; }
        public string TheComment { get; set; }
    }
}
