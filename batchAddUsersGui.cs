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
    internal partial class batchAddUsersGui : Form
    {
        List<User> usersToAdd;
        batchAddUserController controller;

        public batchAddUsersGui(batchAddUserController control)
        {
            InitializeComponent();
            controller = control;
        }

        private void fileUploadButton_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowHelp = true;
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.FileName = "user_list.xls";

            openFileDialog1.Filter = "Excel Files (.xls, .xlsx)|*.xls;*.xlsx|All files (*.*)|*.*";
            openFileDialog1.Title = "Select a user_list Excel File (.xls)";

            // Show the Dialog.  	

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // grab file location from FileDialog
                string path = openFileDialog1.FileName;
                //set textbox to selected filename
                selectedFileText.Text = openFileDialog1.FileName;
                usersToAdd = controller.loadDataFromFile(path);

                batchUserListView.Items.Clear();
             
                foreach (var User in usersToAdd)
                {
                    string id = User.getFirst();
                    string first = User.getLast();
                    string last = User.getUserName();
                    string userName = User.getPass();
                    string level = User.getLevel().ToString();

                    batchUserListView.Items.Add(new ListViewItem(new string[] { id, first, last, userName, level }));
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cofirmButton_Click(object sender, EventArgs e)
        {
            if (usersToAdd != null)
            {
                if (controller.batchAddUsersToDatabase(usersToAdd))
                {
                    MessageBox.Show("Users Sucessfully Added");
                }
                else
                {
                    MessageBox.Show("Users not added, something went wrong!",
                            "Error: Users Not Added", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Please select an Excel sheet with properly formatted users.");
            }
        }
    }
}
