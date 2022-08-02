using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionAout.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        public string UserName { get; set; }

        [Required]
        [MinLength(2)]
        public string Password { get; set; }

        /// <summary></summary>
        /// <remarks></remarks>
        /// <value></value>
        public Role Role { get; set; }

        public override string ToString()
        {
            return UserName;
        }
    }
}
