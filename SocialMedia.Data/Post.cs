using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Data
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set;}

        public DateTimeOffset? ModifiedUtc { get; set; }

<<<<<<< HEAD
        [ForeignKey("Comment")]
=======

        [ForeignKey(nameof(Comment))]
>>>>>>> 436f61619e2e9a491f7ea2343c65373287870b56
        public int CommentId { get; set; }
        public virtual Comment Comment { get; set; }
    }
}
