using System.ComponentModel.DataAnnotations.Schema;

namespace IRDb.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int Year { get; set; }
        public string Genre { get; set; } = string.Empty;

        [Column(TypeName = "decimal(3, 1)")]
        public double Rating { get; set; }
    }
}