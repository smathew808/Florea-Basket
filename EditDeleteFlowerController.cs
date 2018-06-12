using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS325_broadSword_flowerProject
{
    public class EditDeleteFlowerController
    {
        private FlowerList flowerListGUI;

        public EditDeleteFlowerController()
        {

        }

        //Loads the FlowerList GUI
        public void loadFlowerListGUI()
        {
            this.flowerListGUI = new FlowerList(this);
            flowerListGUI.Show();
        }

        //The list of flowers locally stored in this controller
        private List<Flower> flowers = new List<Flower>();

        //Gets the names and Botanical family for each flower for use with the
        //FlowerList GUI
        public List<string> getFlowers()
        {
            flowers = DatabaseManager.getFlowersFromDB();

            List<string> flowerStrings = new List<string>();

            for (int i = 0; i < flowers.Count; i++)
            {
                flowerStrings.Add(flowers[i].getLatinName());
                flowerStrings.Add(flowers[i].getEnglishName());
                flowerStrings.Add(flowers[i].getBotanicalFamily());
            }

            return flowerStrings;
        }

        //Gets an entire flower (including note, pictures, and picture notes) 
        //from the list stored in this controller
        public Flower getFlower(int position)
        {
            return flowers[position];
        }

        //Stores the modified flower into the database by reciving the flower attributes
        //and editing the associated flower in the list. The edited flower is then sent
        //to the database manager to be saved. Used for testing without calling the GUI.
        public void modifyFlowerDirectly(int position, string latinName, string englishName, string botanicalFamily, string flowerNote,
            DateTime noteTimeDate, List<Image> pictures, List<DateTime> pictureTimeDate, List<string> photographers,
            List<string> locations, List<string> pictureNotes, List<string> picturePaths)
        {
            Flower flower = flowers[position];

            flower.setLatinName(latinName);
            flower.setEnglishName(englishName);
            flower.setbotanicalFamily(botanicalFamily);
            flower.setNote(new Note(noteTimeDate, flowerNote));

            flower.pictureList.Clear();

            //have each picture in the list be converted into a sepereate RGB list
            SearchFlowerPictureController flowerPictureController = new SearchFlowerPictureController();

            ViewHistogramController viewHistogramController = new ViewHistogramController();

            //the bin list for each picture for ONE flower
            List<int[]> flowerBinList = new List<int[]>();

            //the single bin list for a pcit
            int[] singleBinList = new int[17];

            //the RGB list for each picture for a flower
            List<Tuple<int, int, int>> RGBList = new List<Tuple<int, int, int>>();

            for (int i = 0; i < pictures.Count; i++)
            {
                //calls function to turn the picture into a RGBList of all the pixels in the picture
                RGBList = flowerPictureController.GetRGBpixelList(pictures[i]);
                //convert from RGB to bin list

                singleBinList = viewHistogramController.makeRGBList(RGBList);

                //currently got 1 RGB list
                flowerBinList.Add(singleBinList);

                flower.pictureList.Add(new Picture(pictures[i], pictureTimeDate[i], photographers[i], locations[i], pictureNotes[i], picturePaths[i], singleBinList));
            }

            DatabaseManager.modifyFlower(flower);
            flowers[position] = flower;
        }

        //Calls the modifyFlowerDirectly function then updates the GUI
        public void modifyFlower(int position, string latinName, string englishName, string botanicalFamily, string flowerNote,
            DateTime noteTimeDate, List<Image> pictures, List<DateTime> pictureTimeDate, List<string> photographers,
            List<string> locations, List<string> pictureNotes, List<string> picturePaths)
        {
            modifyFlowerDirectly(position, latinName, englishName, botanicalFamily, flowerNote, noteTimeDate, pictures, pictureTimeDate, photographers, locations, pictureNotes, picturePaths);
            flowerListGUI.updateFlowerList();
        }

        //Deletes a flower from the database
        public void deleteFlower(int position)
        {
            DatabaseManager.deleteFlower(flowers[position]);
            flowerListGUI.updateFlowerList();
        }

        //Calls the EditFlower GUI
        public void loadEditGUI(int position)
        {
            EditFlower editGUI = new EditFlower(position, this);
            editGUI.Show();
        }
    }
}
