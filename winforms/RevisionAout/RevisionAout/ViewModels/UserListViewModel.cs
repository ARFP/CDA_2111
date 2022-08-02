using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionAout.ViewModels
{
    public class UserListViewModel
    {
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        public string UserName { get; set; }

        public string RoleName { get; set; }

        public UserListViewModel() : this("default") { }

        public UserListViewModel(string name)
        {

        }

    }
}
