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
    public partial class viewFlowerDetails : Form
    {
        public viewFlowerDetails()
        {
            InitializeComponent();
        }

        internal void populateDetails(ref Flower flower)
        {
            englishBox.Text = flower.getEnglishName();
            latinBox.Text = flower.getLatinName();
            botBox.Text = flower.getBotanicalFamily();
            Note note = flower.getNote();
            dateBox.Text = note.getTimeDate().ToString();
            noteBox.Text = note.getNote();
            pictureBox1.Image = flower.pictureList[0].getPicture();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
