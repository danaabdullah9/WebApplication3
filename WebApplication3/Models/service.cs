using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class service
    {
        [Key]
        public int idOrder { get; set; }

        public float price { get; set; }

        public string? nameofThearpy { get; set; }

        public string? nameofThearpist { get; set; }

        public string? whereOf { get; set; }
        public string? image { get; set; }

        public DateTime dateService { get; set; }
    }
}
