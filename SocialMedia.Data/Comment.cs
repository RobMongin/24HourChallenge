using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Data
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }

        [Required, Display(Name = "Comment")]
        public string Content { get; set; }
<<<<<<< HEAD
        public DateTime Created { get; set; }
=======

>>>>>>> 436f61619e2e9a491f7ea2343c65373287870b56
    }
}
