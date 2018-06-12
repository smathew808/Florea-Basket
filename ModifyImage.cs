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
    public partial class ModifyImage : Form
    {
        private AddFlower addParent;
        private EditFlower editParent;

        private Image picture;
        private DateTime timeDate;
        private String photographer;
        private String location;
        private String note;

        //Recieve instance of AddFlower form, picture, and notes for the associated picture.
        public ModifyImage(AddFlower parent, Image picture, DateTime timeDate, String photographer, String location, String note)
        {
            this.addParent = parent;
            this.picture = picture;
            this.timeDate = timeDate;
            this.photographer = photographer;
            this.location = location;
            this.note = note;

            InitializeComponent();
        }

        //Recieve instance of AddFlower form, picture, and notes for the associated picture.
        public ModifyImage(EditFlower parent, Image picture, DateTime timeDate, String photographer, String location, String note)
        {
            this.editParent = parent;
            this.picture = picture;
            this.timeDate = timeDate;
            this.photographer = photographer;
            this.location = location;
            this.note = note;

            InitializeComponent();
        }

        //Load picture and notes into form
        private void ModifyImage_Load(object sender, EventArgs e)
        {
            pictureBox.Image = picture;
            dateTimePicker.Value = timeDate;
            photographerTB.Text = photographer;
            locationTB.Text = location;
            noteTB.Text = note;
        }

        //Call the parent(AddFlower form) to add back into its lists
        private void okButton_Click(object sender, EventArgs e)
        {
            if (editParent == null)
            {
                addParent.recievePictureNote(dateTimePicker.Value, photographerTB.Text, locationTB.Text, noteTB.Text);
            }
            else
            {
                editParent.recievePictureNote(dateTimePicker.Value, photographerTB.Text, locationTB.Text, noteTB.Text);
            }
            
            this.Close();
        }

        //Close form
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
