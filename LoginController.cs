using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CS325_broadSword_flowerProject
{
    public class LoginController
    {
        private User loginUser = new User();

        public bool login(string user, string pass)
        {
            loginUser.setUserName(user);
            loginUser.setPass(pass);

            if (DatabaseManager.checkUserAuth(ref loginUser))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal User returnCurrentUser()
        {
            return loginUser;
        }

        internal void createIfMissing()
        {
            string path = "images";

            string currentPath = Directory.GetCurrentDirectory();
            if (!Directory.Exists(Path.Combine(currentPath, path)))
            {
                Directory.CreateDirectory(Path.Combine(currentPath, path));
            }
        }
    }
}
