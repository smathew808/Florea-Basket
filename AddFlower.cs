using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS325_broadSword_flowerProject
{
    public partial class AddFlower : Form
    {
        FlowerController flowerC = new FlowerController();

        //Lists to hold raw Picture data
        private List<Image> pictures = new List<Image>();
        private List<DateTime> pictureTimeDate = new List<DateTime>();
        private List<String> photographers = new List<String>();
        private List<String> locations = new List<String>();
        private List<String> pictureNotes = new List<String>();
        private List<String> picturePaths = new List<String>();

        //Current position using pictureListView being edited
        private int currentPos;

        public AddFlower()
        {
            InitializeComponent();
        }

        //When a researcher drops (a) picture(s), add it to the list of pictures.
        private void listView1_DragDrop(object sender, DragEventArgs e)
        {
            String[] imageDrops = (String[])e.Data.GetData(DataFormats.FileDrop, true);

            for (int i = 0; i < imageDrops.Length; i++)
            {
                string newLocation = Directory.GetCurrentDirectory() + "\\images\\" + Path.GetFileName(imageDrops[i]);
                if (File.Exists(newLocation))
                {
                    DialogResult result = MessageBox.Show("Picture (" + Path.GetFileName(newLocation) + ") already exists locally. Do you want to use this file?", "File already exists",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        addPicture(newLocation, i);
                    }
                }
                else
                {
                    File.Copy(imageDrops[i], newLocation);
                    addPicture(newLocation, i);
                }
            }
        }

        private void addPicture(String path, int pos)
        {
            picturesList.Images.Add(Image.FromFile(path));
            pictures.Add(Image.FromFile(path));
            pictureListView.Items.Add(Path.GetFileName(path), pos);
            
            pictureTimeDate.Add(DateTime.Now);
            photographers.Add("");
            locations.Add("");
            pictureNotes.Add("");
            picturePaths.Add(path);
        }

        //When a researcher begins dragging a file over the pictureListView, change the mouse to the copy mouse icon.
        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        //Set currentPos to the currently selected picture in the pictureListView. Open the ModifyImage (picture note) form with the selcted picture.
        private void modifyButton_Click(object sender, EventArgs e)
        {
            currentPos = pictureListView.SelectedIndices[0];
            DateTime pictureDate = pictureTimeDate[currentPos];
            ModifyImage modifyNote = new ModifyImage(this, pictures[currentPos], pictureDate, photographers[currentPos], locations[currentPos], pictureNotes[currentPos]);
            modifyNote.ShowDialog();
        }

        //Set modify and delete buttons to enabled or not if a picture is selected.
        private void pictureListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (pictureListView.SelectedItems.Count == 0)
            {
                modifyButton.Enabled = false;
                deletePictureButton.Enabled = false;
            }
            else
            {
                modifyButton.Enabled = true;
                deletePictureButton.Enabled = true;
            }
        }

        //Called from the ModifyImage (picture note) form to add the modified notes to the list using currentPos.
        public void recievePictureNote(DateTime timeDate, String photographer, String location, String note)
        {
            pictureTimeDate[currentPos] = timeDate;
            photographers[currentPos] = photographer;
            locations[currentPos] = location;
            pictureNotes[currentPos] = note;
        }

        //Add (a) picture(s) to the list of pictures.
        private void addPictureButton_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();

            for (int i = 0; i < openFileDialog.FileNames.Length; i++)
            {
                string newLocation = Directory.GetCurrentDirectory() + "\\images\\" + Path.GetFileName((openFileDialog.FileNames[i]));
                if (File.Exists(newLocation))
                {
                    DialogResult result = MessageBox.Show("Picture (" + Path.GetFileName(newLocation) + ") already exists locally. Do you want to use this file?", "File already exists",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(result == DialogResult.Yes)
                    {
                        addPicture(newLocation, i);
                    }
                }
                else
                {
                    File.Copy(openFileDialog.FileNames[i], newLocation);
                    addPicture(newLocation, i);
                }
            }
        }

        //Delete the picture and associated notes from the lists.
        private void deletePictureButton_Click(object sender, EventArgs e)
        {
            int pos = pictureListView.SelectedIndices[0];

            picturesList.Images.RemoveAt(pos);
            pictures.RemoveAt(pos);
            pictureListView.Items.RemoveAt(pos);
            pictureTimeDate.RemoveAt(pos);
            photographers.RemoveAt(pos);
            locations.RemoveAt(pos);
            pictureNotes.RemoveAt(pos);
            picturePaths.RemoveAt(pos);
        }

        //Close form
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Call the FlowerController to create the flower object and add/check for duplicates in the DB.
        private void addButton_Click(object sender, EventArgs e)
        {
            if(botanicalFamilyTB.Text == "")
            {
                MessageBox.Show("Flower is missing a botanical family!", "Missing Botanical Family",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!flowerC.addFlower(latinNameTB.Text, englishNameTB.Text, botanicalFamilyTB.Text, notesTB.Text,
            noteDateTimePicker.Value, pictures, pictureTimeDate, photographers, locations, pictureNotes, picturePaths))
                {
                    MessageBox.Show("Flower was not successfully added to DB! Duplicate detected.", "Duplicate detected",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
