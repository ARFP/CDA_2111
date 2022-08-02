using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionAout.ViewModels
{
    public class UserAddViewModel
    {
        [Required]
        [MinLength(2)]
        public string UserName { get; set; }

        [Required]
        [MinLength(4)]
        [RegularExpression("[A-Z]")]
        public string Password { get; set; }

        [Required]
        [MinLength(4)]
        public string PasswordConfirm { get; set; }
    }
}
