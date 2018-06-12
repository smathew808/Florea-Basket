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
    public partial class EditUsers : Form
    {
        deleteUserController delUser = new deleteUserController();

        public EditUsers()
        {
            InitializeComponent();
        }

        private void EditUsers_Load(object sender, EventArgs e)
        {
            var users = delUser.populateList();
            foreach (var User in users)
            {
                string id = User.getUID().ToString();
                string first = User.getFirst();
                string last = User.getLast();
                string userName = User.getUserName();
                string level = User.getLevel().ToString();

                userListView.Items.Add(new ListViewItem(new string[] { id, first, last, userName, level }));
            }
        }

        private void editUserButton_Click(object sender, EventArgs e)
        {
            if (userListView.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intselectedindex = userListView.SelectedIndices[0];
            if (intselectedindex >= 0)
            {
                String text = userListView.Items[intselectedindex].Text;
                int passedID = Int32.Parse(text);
                if (delUser.editUsers(passedID))
                {
                    MessageBox.Show("Selected user with ID:" + passedID + " changed.");
                }
                else
                {
                    MessageBox.Show("User not edited, something went wrong",
                        "Error: User not edited", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
