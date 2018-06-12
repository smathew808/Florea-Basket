using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS325_broadSword_flowerProject
{
    public class UserController
    {
        
        public UserController()
        {

        }

        public bool createNewUser(String first, String last, String userName, String pass, int access)
        {
            String firstName = first;
            String lastName = last;
            String user = userName;
            String password = pass;
            int level = access;
            bool test;

            User newUser = new User();

            newUser.setFirst(first);
            newUser.setLast(last);
            newUser.setUserName(userName);
            newUser.setPass(password);
            newUser.setLevel(level);

            if (DatabaseManager.inputUser(ref newUser))
            {
                Console.WriteLine("Data Saved");
                test = true;
            }
            else
            {
                Console.WriteLine("Error: Data not saved");
                test = false;
            }
            return test;
        }


    }
}