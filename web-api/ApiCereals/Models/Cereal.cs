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
        [MinLength(2, ErrorMessage="")]
        [MaxLength(32)]
        [StringLength(32, MinimumLength = 2)]
        [RegularExpression("^[a-zA-Z]{2,32}$")]
        public string Name { get; set; }


    }
}
