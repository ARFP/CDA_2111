using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCereals.Models
{
    [Table("toto")]
    public class Cereal
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Le champs est requis")]
        [MinLength(2, ErrorMessage = "")]
        [MaxLength(32)]
        [StringLength(32, MinimumLength = 2)]
        [RegularExpression("^[^_]{2,32}$", ErrorMessage = "Le format est incorrect")]
        public string Name { get; set; }

        [Required]
        [Range(-1, 500)]
        public int Calories { get; set; }

        [Required]
        [Range(-1, 500)] 
        public int Protein { get; set; }

        [Required]
        [Range(-1, 500)] 
        public int Sodium { get; set; }

        [Required]
        [Range(-1, 500)]
        public int Fiber { get; set; }

        [Required]
        [Range(-1, 500)]
        public int Carbo { get; set; }

        [Required]
        [Range(-1, 500)]
        public int Sugars { get; set; }

        [Required]
        [Range(-1, 500)]
        public int Potass { get; set; }

        [Required]
        [Range(-1, 500)]
        public int Vitamins { get; set; }

        [Required]
        [Range(0.0, 100.0)]
        public decimal Rating { get; set; }

    }
}
