using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS325_broadSword_flowerProject
{
    public class FlowerController
    {
        //DatabaseManager dbMg = new DatabaseManager();

        //Take in the raw flower data (not flower object), add the raw data to a flower object, and then
        //call the database manager for duplicate checking.
        public bool addFlower(string latinName, string englishName, string botanicalFamily, string flowerNote,
            DateTime noteTimeDate, List<Image> pictures, List<DateTime> pictureTimeDate, List<string> photographers,
            List<string> locations, List<string> pictureNotes, List<string> paths)
        {
            Note note = new Note(noteTimeDate, flowerNote);

            //have each picture in the list be converted into a sepereate RGB list
            SearchFlowerPictureController flowerPictureController = new SearchFlowerPictureController();

            ViewHistogramController viewHistogramController = new ViewHistogramController();

            //the bin list for each picture for ONE flower
            List<int[]> flowerBinList = new List<int[]>();

            //the single bin list for a pcit
            int[] singleBinList = new int[17];

            //the RGB list for each picture for a flower
            List<Tuple<int, int, int>> RGBList = new List<Tuple<int, int, int>>();

            Flower flower = new Flower(latinName, englishName, botanicalFamily, note);

            for (int i = 0; i < pictures.Count; i++)
            {

                //reisze the picuter
                pictures[i] = flowerPictureController.ResizeImage(pictures[i], 227, 171);

                //calls function to turn the picture into a RGBList of all the pixels in the picture
               RGBList = flowerPictureController.GetRGBpixelList(pictures[i]);

                //convert from RGB to bin list
                singleBinList = viewHistogramController.makeRGBList(RGBList);

                flower.pictureList.Add(new Picture(pictures[i], pictureTimeDate[i], photographers[i], locations[i], pictureNotes[i], paths[i], singleBinList));
                
            }

            

            return DatabaseManager.storeFlowerInDB(flower);
        }
    }
}
