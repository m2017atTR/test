using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Trade
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Journal
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
