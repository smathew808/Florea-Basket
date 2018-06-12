using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS325_broadSword_flowerProject
{
    public class mainmenuController
    {
        mainmenuGUI gui;

        public mainmenuController(User user)
        {
            var currentUser = user.getCurrentUser();
            this.gui = new mainmenuGUI(this, currentUser.Item3, currentUser.Item4, currentUser.Item5);
            gui.ShowDialog();
        }

        public void addUser()
        {
            AddUser newUser = new AddUser();
            newUser.Show();
        }

        public void batchAddUsers()
        {
            batchAddUserController batch = new batchAddUserController();
            batch.constructGUI();
        }

        public void editUser()
        {
            EditUsers edit = new EditUsers();
            edit.ShowDialog();
        }

        public void deleteUser()
        {
            deleteUser del = new deleteUser();
            del.Show();
        }

        public void addFlower()
        {
            AddFlower addFlower = new AddFlower();
            addFlower.Show();
        }

        public void editDeleteFlower()
        {
            EditDeleteFlowerController editDeleteFController = new EditDeleteFlowerController();
            editDeleteFController.loadFlowerListGUI();
        }

        public void viewHistogram()
        {
            ViewHistogramController histogramController = new ViewHistogramController();
            histogramController.constructHistoGUI();
        }

        public void logout()
        {
            Login newLogin = new Login();
            newLogin.ShowDialog();
        }
    }
}
