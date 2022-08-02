using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
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


        public override string ToString()
        {
            return UserName + " : " + base.ToString(); ;
        }
    }
}
