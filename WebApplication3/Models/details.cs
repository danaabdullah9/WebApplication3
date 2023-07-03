using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models
{
    public class details
    {
        [Key]
        public int id { get; set; }


        public string? description { get; set; }

        public string? image { get; set; }

        public string? aboutThearpist { get; set; }

        public service? Products { get; set; }

    }
}
