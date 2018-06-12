using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS325_broadSword_flowerProject
{
    public class User
    {
        private string firstName;
        private string lastName;
        private string username;
        private string password;
        private int accessLevel;
        private int UID;

        private int currentID;
        private string currentFirst;
        private string currentLast;
        private string currentUserName;
        private int currentAccessLevel;

        public void setFirst(string first)
        {
            firstName = first;
        }

        public string getFirst()
        {
            return firstName;
        }

        public void setLast(string last)
        {
            lastName = last;
        }

        public string getLast()
        {
            return lastName;
        }

        public void setUserName(string user)
        {
            username = user;
        }

        public string getUserName()
        {
            return username;
        }

        public void setPass(string pass)
        {
            password = pass;
        }

        public string getPass()
        {
            return password;
        }

        public void setLevel(int level)
        {
            accessLevel = level;
        }

        public int getLevel()
        {
            return accessLevel;
        }

        public void setUID(int Id)
        {
            UID = Id; 
        }

        public int getUID()
        {
            return UID;
        }

        public void setCurrentUser(int id, string userName, string first,
                                   string last, int accessLevel)
        {
            if ((id < 0) || (accessLevel < 0))
            {
                Console.WriteLine("ERROR: ID / Access Level invalid! Something went wrong!");
            } else
            {
                currentID = id;
                currentFirst = first;
                currentLast = last;
                currentUserName = userName;
                currentAccessLevel = accessLevel;
            }
        }

        public Tuple<int, string, string, string, int> getCurrentUser()
        {
            var user = new Tuple<int, string, string, string, int>
                (currentID, currentUserName, currentFirst, currentLast, currentAccessLevel);

            return user;
        }
    }
}
