using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace CS325_broadSword_flowerProject
{
    //Developer: Sean Mathews
    //Objective: Create search functionality for string data types
    //Class: CS-325
    //Instructor: Mayer

    public partial class SearchFlowerGUI : Form
    {

        //Lists to hold raw Picture data


        public Image searchPicture;

        SearchFlowerLanguageController searchController;

        public SearchFlowerGUI(SearchFlowerLanguageController controller)
        {

            InitializeComponent();

            searchController = controller;

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            List<int> results;
            //save the input from the user
            int searchType = SearchTypeBox.SelectedIndex;
            string searchEntry = SearchEntryBox.Text;

            

            if ((searchType == 0) || (searchType == 1) || (searchType == 2))
            {
                SearchFlowerLanguageController languageController = new SearchFlowerLanguageController();

                //calls the ctlr to get the searchList from the DBM, giving the searchType and Search Entry from the User
                results = languageController.getSearchList(searchType, searchEntry);

                for (int i = 0; i < results.Count; i++)
                {
                    Console.WriteLine(results[i]);
                }

                //if the results list is empty then print a no results found message to the user
                if (results.Count == 0)
                {
                    MessageBox.Show("No results have been found!");
                }
            }

            else
            {
                SearchFlowerPictureController pictureController = new SearchFlowerPictureController();

                //gets the image file path, now gotta pass it to the controller
                searchPicture = searchAddPicture(openFileDialog1.FileName);



                searchPicture = pictureController.ResizeImage(searchPicture, 50, 50);

                results = pictureController.getPictureSearchList(searchPicture);

                for (int i = 0; i < results.Count; i++)
                {
                    Console.WriteLine(results[i]);
                }

                //if the results list is empty then print a no results found message to the user
                if (results.Count == 0)
                {
                    MessageBox.Show("No results have been found!");
                }

            }



            //This will print the Int Id of the Flower in the console, meaning that the next use-case, display results, 
            //will take this list and ask for the flower information and display them to the user in iteration 3





        }

        private Image searchAddPicture(String path)
        {
            searchPicture = Image.FromFile(path);

            return searchPicture;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addPictureButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            searchPictureBox.Load(openFileDialog1.FileName);
        }

    }
}