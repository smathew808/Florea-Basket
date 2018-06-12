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
    public partial class editUserDialog : Form
    {

        private int userId;
        private User userToEdit = new User();
        private deleteUserController delUser;

        public editUserDialog()
        {
            InitializeComponent();
        }

        private void editUserDialog_Load(object sender, EventArgs e)
        {

        }

        internal void setId(int id)
        {
            userId = id;
        }

        internal void setRef(deleteUserController del)
        {
            delUser = del;
        }

        internal void onLoad()
        {
            DatabaseManager.getUserData(userId, ref userToEdit);
            var userToEditData = userToEdit.getCurrentUser();

            firstText.Text = userToEditData.Item3;
            lastText.Text = userToEditData.Item4;
            userText.Text = userToEditData.Item2;
            levelCombo.SelectedIndex = userToEditData.Item5 - 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userToEdit.setFirst(firstText.Text);
            userToEdit.setLast(lastText.Text);
            userToEdit.setLevel(levelCombo.SelectedIndex + 1);
            userToEdit.setUserName(userText.Text);
            userToEdit.setPass(passText.Text);
            userToEdit.setUID(userId);

            if (delUser.editUser(ref userToEdit))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Error: something went wrong", "edit user error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
