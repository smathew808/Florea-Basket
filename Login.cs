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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string userInput = UserNameInput.Text;
            string pass = PasswordInput.Text;
            bool auth;

            LoginController login = new LoginController();

            auth = login.login(userInput, pass);
            if (auth)
            {
                User current = login.returnCurrentUser();
                var user = current.getCurrentUser();

                login.createIfMissing();

                MessageBox.Show("Welcome " + user.Item3 +" "+ user.Item4 + " take time to smell the flowers.");
                this.Hide();
                //TestButtons runProgram = new TestButtons();
                mainmenuController mainmenu = new mainmenuController(current);
                //runProgram.ShowDialog();
                this.Close();
            } else
            {
                MessageBox.Show("Incorrect Username or Password", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
