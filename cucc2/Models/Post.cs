using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cucc2.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string? Category { get; set; }
        [Required]
        [Column(TypeName = "longtext")]
        public string? Description { get; set; }
        [Required]
        public bool Comments { get; set; }
        public int BloggerId { get; set; }
        public DateTime RegTime { get; set; } = DateTime.Now;
        public DateTime ModTime { get; set; } = DateTime.Now;
        public virtual Blogger Bloggers { get; set; }
    }
}
