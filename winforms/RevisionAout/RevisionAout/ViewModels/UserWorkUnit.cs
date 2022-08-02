using RevisionAout.Models;
using RevisionAout.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionAout.Dao
{
    public class UserWorkUnit
    {

        public void Adduser(UserAddViewModel model)
        {
            // si le view model est valide 

            User user = new User()
            {
                UserName = model.UserName,
                Password = model.Password,
                Role = new Role() { RoleId = 1, RoleName = "Guest"}
            };


        }

        public UserListViewModel getUser(int id)
        {
            UserListViewModel u = new UserListViewModel();
        }
    }
}
