using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS325_broadSword_flowerProject
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void addUser_Load(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string first = firstInput.Text;
            string last = lastInput.Text;
            string userName = usernameInput.Text;
            string password = passInput.Text;
            int access = accessSelect.SelectedIndex+1;

            UserController userController = new UserController();

            if(userController.createNewUser(first, last, userName, password, access)){
                this.Close();
            } else
            {
                Console.WriteLine("ERROR!");
            }
        }
    }
}
