using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS325_broadSword_flowerProject
{
    public class deleteUserController
    {
        private List<User> currUsers = new List<User>();

        internal List<User> populateList()
        {
            currUsers = DatabaseManager.getUsers();

            return currUsers;
        }

        public bool delUsers(int id)
        {
            return DatabaseManager.deleteUser(id);
        }

        public bool editUser(ref User userToEdit)
        {
            return DatabaseManager.editUserData(ref userToEdit);
        }

        internal bool editUsers(int id)
        {
            editUserDialog editAUser = new editUserDialog();
            editAUser.setId(id);
            editAUser.setRef(this);
            editAUser.onLoad();
            editAUser.ShowDialog();

            return true;
        }
    }
}
