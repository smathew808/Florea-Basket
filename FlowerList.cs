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
    public partial class FlowerList : Form
    {
        EditDeleteFlowerController controller;

        public FlowerList(EditDeleteFlowerController controller)
        {
            this.controller = controller;

            InitializeComponent();
        }

        private void FlowerList_Load(object sender, EventArgs e)
        {
            updateFlowerList();
        }

        private void flowerListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (flowerListView.SelectedItems.Count == 0)
            {
                editFlowerButton.Enabled = false;
                deleteFlowerButton.Enabled = false;
            }
            else
            {
                editFlowerButton.Enabled = true;
                deleteFlowerButton.Enabled = true;
            }
        }

        private void editFlowerButton_Click(object sender, EventArgs e)
        {
            controller.loadEditGUI(flowerListView.SelectedIndices[0]);
        }

        public void updateFlowerList()
        {
            flowerListView.Items.Clear();

            List<string> flowerStrings = controller.getFlowers();

            for (int i = 0; i < flowerStrings.Count; i += 3)
            {
                flowerListView.Items.Add(flowerStrings[i]);
                flowerListView.Items[flowerListView.Items.Count - 1].SubItems.Add(flowerStrings[i + 1]);
                flowerListView.Items[flowerListView.Items.Count - 1].SubItems.Add(flowerStrings[i + 2]);
            }

            editFlowerButton.Enabled = false;
            deleteFlowerButton.Enabled = false;
        }

        private void deleteFlowerButton_Click(object sender, EventArgs e)
        {
            controller.deleteFlower(flowerListView.SelectedIndices[0]);
        }
    }
}
