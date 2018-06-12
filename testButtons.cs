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
    public partial class TestButtons : Form
    {
        public TestButtons()
        {
            InitializeComponent();
            UserController userController = new UserController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUser newUser = new AddUser();
            newUser.Show();
        }

        private void addFlowerButton_Click(object sender, EventArgs e)
        {
            AddFlower addFlower = new AddFlower();
            addFlower.Show();
        }

        private void histoButton_Click(object sender, EventArgs e)
        {
            ViewHistogramController histoController = new ViewHistogramController();
            histoController.constructHistoGUI();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to logout?", "Logout?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                Login newLogin = new Login();
                newLogin.ShowDialog();
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            deleteUser del = new deleteUser();
            del.Show();
        }

        private void batchAddButton_Click(object sender, EventArgs e)
        {
            batchAddUserController batch = new batchAddUserController();
            batch.constructGUI();
        }

        private void editDFlowerButton_Click(object sender, EventArgs e)
        {

        }

        private void editDeleteFlower_Click(object sender, EventArgs e)
        {
            EditDeleteFlowerController editDeleteFController = new EditDeleteFlowerController();
            editDeleteFController.loadFlowerListGUI();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to logout?", "Logout?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                Login newLogin = new Login();
                newLogin.ShowDialog();
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            //makes the object, and calls the constructor in the controller to make the new gui object and show it

            SearchFlowerLanguageController searchFlowerController = new SearchFlowerLanguageController();
            searchFlowerController.constructSearchGUI();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login newLogin = new Login();
            newLogin.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            EditUsers edit = new EditUsers();
            edit.ShowDialog();
        }

        private void PrintToPDFControllerButton_Click(object sender, EventArgs e)
        {
            List<Flower> flowers = DatabaseManager.getFlowersFromDB();

            PrintToPDFController cont = new PrintToPDFController();
            cont.createPDF(flowers, "test.pdf");

            MessageBox.Show("PDF saved successfully to test.pdf");
        }

        private void mainmenuGUIButton_Click(object sender, EventArgs e)
        {
            //mainmenuGUI mainmenu = new mainmenuGUI();
            //mainmenu.ShowDialog();
        }
    }
}
