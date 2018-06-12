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
    public partial class deleteUser : Form
    {
        deleteUserController delUser = new deleteUserController();

        public deleteUser()
        {
            InitializeComponent();
        }

        private void deleteUser_Load(object sender, EventArgs e)
        {

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            usersListView.Clear();
            this.usersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idCol,
            this.firstCol,
            this.LastCol,
            this.userCol,
            this.accessColum});
            this.firstCol.Text = "First";
            this.firstCol.Width = 100;
            this.LastCol.Text = "Last";
            this.LastCol.Width = 100;
            this.userCol.Text = "User Name";
            this.userCol.Width = 125;
            this.accessColum.Text = "Access Level";
            this.accessColum.Width = 100;
            this.idCol.Text = "ID";
            this.idCol.Width = 25;

            var users = delUser.populateList();
            foreach(var User in users)
            {
                string id = User.getUID().ToString();
                string first = User.getFirst();
                string last = User.getLast();
                string userName = User.getUserName();
                string level = User.getLevel().ToString();

                usersListView.Items.Add(new ListViewItem(new string[] {id, first, last, userName, level}));
            }
        }

        private void delUserButton_Click(object sender, EventArgs e)
        {
            if (usersListView.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intselectedindex = usersListView.SelectedIndices[0];
            if (intselectedindex >= 0)
            {
                String text = usersListView.Items[intselectedindex].Text;
                int passedID = Int32.Parse(text);
                if (delUser.delUsers(passedID))
                {
                    MessageBox.Show("Selected user with ID:" + passedID + " deleted.");
                } else
                {
                    MessageBox.Show("User not deleted, something went wrong", 
                        "Error: User not deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
