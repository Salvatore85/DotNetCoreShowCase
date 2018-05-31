using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreShowCase.Api.Entities
{
    public class BlogPost
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public DateTime DatePosted { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Article { get; set; }
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();

        // Relationship with User Entity
        public User User { get; set; }
        public int UserId { get; set; }
    }
}
