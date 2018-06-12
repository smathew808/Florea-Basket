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
    public partial class mainmenuGUI : Form
    {
        mainmenuController parent;
        string firstName;
        string lastName;
        int permissionLevel;

        public mainmenuGUI(mainmenuController parent, string firstName, string lastName, int permissionLevel)
        {
            this.parent = parent;
            this.firstName = firstName;
            this.lastName = lastName;
            this.permissionLevel = permissionLevel;

            InitializeComponent();
        }

        private void mainmenuGUI_Load(object sender, EventArgs e)
        {
            searchTypeBox.SelectedIndex = 0;

            string level;
            switch (permissionLevel)
            {
                case 1:     level = "Student"; flowersToolStripMenuItem.Visible = false; usersToolStripMenuItem.Visible = false; break;
                case 2:     level = "Admin"; usersToolStripMenuItem.Visible = false; break;
                case 3:     level = "Researcher"; break;
                default:    level = "User"; flowersToolStripMenuItem.Visible = false; usersToolStripMenuItem.Visible = false; break;
            }
            loginStatusLabel.Text += firstName + " " + lastName + " (" + level + ")";

            viewResultsList.CheckBoxes = true;
        }

        private void imageSearchPanel_DragDrop(object sender, DragEventArgs e)
        {
            String[] imageDrops = (String[])e.Data.GetData(DataFormats.FileDrop, true);

            Image searchPic = Image.FromFile(imageDrops[0]);

            SearchFlowerPictureController pictureSearchCtlr = new SearchFlowerPictureController();

            //make flower list
            List<Flower> flowerInfo = new List<Flower>();

            searchPictureBox.Image = searchPic;
            searchPictureBox.Visible = true;
            dragDropLabel.Visible = false;
            dragDropLinkLabel.Location = new Point(348, 80);

            //do the search for the flower list using a picture
            List<int> foundFlowers = pictureSearchCtlr.getPictureSearchList(searchPic);

            //get the found flowers from the search
            foreach (int value in foundFlowers)
            {
                flowerInfo.Add(DatabaseManager.getFlowerById(value));
            }

            //display the found flowers to the GUI
            foreach (var Flower in flowerInfo)
            {
                string latinName = Flower.getEnglishName();
                string englishName = Flower.getLatinName();
                string BotFamily = Flower.getBotanicalFamily();
                string id = Flower.getID().ToString();

                viewResultsList.Items.Add(new ListViewItem(new string[] { "", latinName, englishName, BotFamily, id }));
            }


        }

        private void imageSearchPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to logout?", "Logout?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                parent.logout();
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void logOutAndExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addFlowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parent.addFlower();
        }

        private void editDeleteFlowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parent.editDeleteFlower();
        }

        private void viewHistogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parent.viewHistogram();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parent.addUser();
        }

        private void batchAddUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parent.batchAddUsers();
        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parent.editUser();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parent.deleteUser();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SearchFlowerPictureController pictureSearchCtlr = new SearchFlowerPictureController();

            //make flower list
            List<Flower> flowerInfo = new List<Flower>();

           

            openFileDialog.ShowDialog();

            if(openFileDialog.FileName != "")
            {
                //grab the image
                Image searchPic = Image.FromFile(openFileDialog.FileName);

                searchPictureBox.Image = searchPic;
                searchPictureBox.Visible = true;
                dragDropLabel.Visible = false;
                dragDropLinkLabel.Location = new Point(348, 80);

                //do the search for the flower list using a picture
                List<int> foundFlowers = pictureSearchCtlr.getPictureSearchList(searchPic);

                //get the found flowers from the search
                foreach (int value in foundFlowers)
                {
                    flowerInfo.Add(DatabaseManager.getFlowerById(value));
                }

                //display the found flowers to the GUI
                foreach (var Flower in flowerInfo)
                {
                    string latinName = Flower.getEnglishName();
                    string englishName = Flower.getLatinName();
                    string BotFamily = Flower.getBotanicalFamily();
                    string id = Flower.getID().ToString();

                    viewResultsList.Items.Add(new ListViewItem(new string[] { "", latinName, englishName, BotFamily, id }));
                }

            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            viewResultsList.Items.Clear();
           

            SearchFlowerLanguageController search = new SearchFlowerLanguageController();
            string userInput = searchBox.Text;
            int selectedSearchType = searchTypeBox.SelectedIndex;
            List<Flower> flowerInfo = new List<Flower>();

            if ( (selectedSearchType == 0) || (selectedSearchType == 1) || (selectedSearchType == 2))
            {

                

                List<int> foundFlowers = search.getSearchList(selectedSearchType, userInput);

                foreach (int value in foundFlowers)
                {
                    flowerInfo.Add(DatabaseManager.getFlowerById(value));
                }

                foreach (var Flower in flowerInfo)
                {
                    string latinName = Flower.getEnglishName();
                    string englishName = Flower.getLatinName();
                    string BotFamily = Flower.getBotanicalFamily();
                    string id = Flower.getID().ToString();

                    viewResultsList.Items.Add(new ListViewItem(new string[] { "", latinName, englishName, BotFamily, id }));
                }
                
            }

            else
            {
                //Image searchPicture;
                //searchPicture = openFileDialog

                //List<int> foundFlowers = pictureSearchCtlr.getPictureSearchList()


            }
         
        }

        private void viewDetailsButton_Click(object sender, EventArgs e)
        {
            if(viewResultsList.SelectedItems.Count != 0)
            {
                errorLabel.Text = "";

                int colIndex = viewResultsList.SelectedIndices[0];
                int selectFlower = Int32.Parse(viewResultsList.Items[colIndex].SubItems[4].Text);
                Flower passedFlower = DatabaseManager.getFlowerById(selectFlower);

                viewFlowerDetails flowerDets = new viewFlowerDetails();
                flowerDets.populateDetails(ref passedFlower);
                flowerDets.ShowDialog();
            } else
            {
                errorLabel.Text = "Error: Please select valid result.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string path = saveFileDialog1.FileName;
            List<Flower> selectedIds = new List<Flower>();
            PrintToPDFController andrewsGreatController = new PrintToPDFController();

            foreach (ListViewItem item in viewResultsList.Items)
            {
                if (item.Checked)
                {
                    selectedIds.Add(DatabaseManager.getFlowerById(Int32.Parse(item.SubItems[4].Text)));
                }
            }

            andrewsGreatController.createPDF(selectedIds, path);
        }
    }
}
