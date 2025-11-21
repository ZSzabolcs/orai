using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cucc2.Models
{
    public class Blogger
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string? Name { get; set; }
        [Required]
        [Column(TypeName = "text")]
        public string? Password { get; set; }
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string? Email { get; set; }
        public DateTime Regtime { get; set; } = DateTime.Now;
        public DateTime Modtime { get; set; } = DateTime.Now;
    }
}
