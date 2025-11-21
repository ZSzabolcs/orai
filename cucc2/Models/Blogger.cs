namespace cucc2.Models
{
    public class Blogger
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public DateTime Regtime { get; set; } = DateTime.Now;
        public DateTime Modtime { get; set; } = DateTime.Now;
    }
}
