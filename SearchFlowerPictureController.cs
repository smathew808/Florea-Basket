using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
///////////////////////////
//developer: Sean Mathews//
///////////////////////////

namespace CS325_broadSword_flowerProject
{
    /// <summary>
    /// the user will select a picture from the dropbox menu in the GUI and will search based off the picture
    /// the GUI will call the viewhistogram functions to make an RGB list of specific values perhaps?
    /// once that happens then it will ask the dbm to return all the flower int ids and each corresponding RGB list
    /// then would it be necessary to call the viewhistogram functions again to return consolidated lists that is the actual histogram values?
    /// once do that then do chi square stuff and sort alg stuff
    /// then return top 3 results
    /// hand off to display results class
    /// end of usecase
    /// </summary>
   public class SearchFlowerPictureController
    {
        //going to use stub temporarily to get alg working
        //get my stubs, stubs will be straight up rgb lists that will be read in from gui

        //test list
        int[] redTestList = new int[5];
        int[] greenTestList = new int[5];
        int[] blueTestList = new int[5];

        //for test
        private const int COLOR_MIN_VALUE = 0;
        private const int COLOR_MAX_VALUE = 255;

        private const int MIN_VALUE = 0;
        private const int RECTANGLE_MAX_VALUE = 10;

        //class variable to draw user's histogram if necessary
        int[] userRGBBinList = new int[17];

        public SearchFlowerPictureController()
        {

        }

        public List<int> getPictureSearchList(Image searchImage)
        {
            //the result list for the flower DB
            List<int> resultList = new List<int>();

            //user rgb bin list
            

            //the RGBList of the user's image
            List<Tuple<int, int, int>> userImageRGBList = new List<Tuple<int, int, int>>();

            //make the bin list
            ViewHistogramController histoContoller = new ViewHistogramController();


            //Bitmap resizedSearchImageBitMap = new Bitmap(searchImage, 227, 171);


            Bitmap resizedSearchImageBitMap = ResizeImage(searchImage, 227, 171);

           userImageRGBList = GetRGBpixelList(resizedSearchImageBitMap);

           userRGBBinList = histoContoller.makeRGBList(userImageRGBList);

            

            //add default values for a maximum space of 3 list items
            //resultList.Add(0);
            //resultList.Add(0);
            //resultList.Add(0);

            //the list that will hold all the chiValues, and the corresponding flowers
            List<Tuple<int, double>> possibleChiValuesList = new List<Tuple<int, double>>();

            List<int[]> binList = new List<int[]>();

            //make the DB list
            List<Tuple<int, int[]>> DbBinList = new List<Tuple<int, int[]>>();

            //get the DB list

            DbBinList = DatabaseManager.GetBinList();

            //calculate each ChiValue for the UserBin list and a Photo's bin list(Both histograms)
            double chiValue;

            for (int i = 0; i < DbBinList.Count; i++)
            {


                 chiValue = calculateChiSquare(userRGBBinList, DbBinList[i].Item2);

                possibleChiValuesList.Add(new Tuple<int, double>(DbBinList[i].Item1, chiValue));
            }
         

            //returns the result list from the search of the top three flowers found

            //passed in result list because for the purpose of modularizing, and resultList is has three values in it, and the computesearch function
            //will find the top three results, no more than three results period
            resultList = computePictureSearch(possibleChiValuesList, resultList);

            return resultList;
        }


        public Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        public List<Tuple<int,int,int>> GetRGBpixelList(Image sourceImage)
        {
            //make an empty list
            List<Tuple<int, int, int>> colorList = new List<Tuple<int, int, int>>();

            using (Bitmap bmp = new Bitmap(sourceImage))
            using (Bitmap rgbBmp = new Bitmap(sourceImage.Width, sourceImage.Height))
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    for (int y = 0; y < bmp.Height; y++)
                    {

                        //find a pixel
                         Color pixel = bmp.GetPixel(x, y);
                        //get the RGB value from that pixel
                        int red = pixel.R;
                        int green = pixel.G;
                        int blue = pixel.B;

                        //store it into the list
                        colorList.Add(new Tuple<int, int, int>(red, green, blue));
                    }
                }

               
            }

            return colorList;
        }

        public List<int> computePictureSearch(List<Tuple<int, double>> ChiValuesList, List<int> searchResultList)
        {

            //at the end of each iteration in this for loop the first best result will be in, then the second, then third.
            for (int i = 0; i < 3; i++)
            {
                //to help to find the smallest ChiValue for all the possible Chi Values in the list
                double smallestChiValue = 1.0;

                //this will iterate through the chiValues to find the current smallest chi value
                for (int j = 0; j < ChiValuesList.Count; j++)
                {
                    
                    //to see if ther are any duplciates in the ResultList
                    int forLoopBreaker = 0;



                    //next need a winner int



                    //this for loop will check for duplciates, and if there is one, then dont bother trying to check 
                    for (int c = 0; c < searchResultList.Count; c++)
                    {
                        if (searchResultList[c] == ChiValuesList[j].Item1)
                        {
                            forLoopBreaker = 1;
                            break;
                        }
                    }

                    //to get out of the second for loop when the alg encounters a flower already in the results list
                    if (forLoopBreaker == 1)
                    {
                        //skip the smallestChiValue, this already skips it since its an if else if chain
                    }


                    //now i want to see who has the smallest value, this will find THE smallest chiSqaure value possible
                    //Assigns a winner
                    else if (smallestChiValue > ChiValuesList[j].Item2)
                    {
                        smallestChiValue = ChiValuesList[j].Item2;

                        //this is saying that if you find a flower's chiSqaure value to be smaller than the current smallest chi value,
                        //then assign the value at resultList[i]! INDEX i! because after each iteration of the for loop for the i'th index will have the smallest value for each iteration
                        searchResultList.Add(ChiValuesList[j].Item1);
                    }



                }
                //at this point, we are guaranteed the smallest possible chi square value for a flower, and will iterate.

            }


            return searchResultList;
        }

            
        

        public double calculateChiSquare(int[] userInputPicture, int[] databasePicture)
        {
            //can calculate the sum of indexes 1,2,3, 5,6,7, 9,10,11, 13,14,15
            //indexes 0, 4, 12, 16 are all just spaces for the histogram

            double finalChiValue = 0.0;

            double redChiSum = 0.0;
            double greenChiSum = 0.0;
            double blueChiSum = 0.0;

            double redChiValue;
            double greenChiValue;
            double blueChiValue;

            
            ////////////////////////////////////////////////////////
            ///////////////////////RED SECTION//////////////////////
            ////////////////////////////////////////////////////////

            //top part of each sub-task in the whole sum
            double substractedSumIndex1 = userInputPicture[1] - databasePicture[1];
            double subtractedSumIndex5 = userInputPicture[5] - databasePicture[5];
            double subtractedSumIndex9 = userInputPicture[9] - databasePicture[9];
            double subtractedSumIndex13 = userInputPicture[13] - databasePicture[13];
            
            //bottom part of each sub-task in the whole sum
            double sumIndex1 = userInputPicture[1] + databasePicture[1];
            double sumIndex5 = userInputPicture[5] + databasePicture[5];
            double sumIndex9 = userInputPicture[9] + databasePicture[9];
            double sumIndex13 = userInputPicture[13] + databasePicture[9];

            //the reason why we worry about if the bottom is equal to 0 is because if it does, that means you will divide by 0
            //WHICH IS A NO NO BAD
            if (sumIndex1 != 0)
            {
                //square                                        //addition
                redChiSum += (substractedSumIndex1 * substractedSumIndex1) / (sumIndex1);
            }

            if (sumIndex5 != 0)
            {
                redChiSum += (subtractedSumIndex5 * subtractedSumIndex5) / (sumIndex5);
            }
            if (sumIndex9 != 0)
            {
                redChiSum += (subtractedSumIndex9 * subtractedSumIndex9) / (userInputPicture[9] + databasePicture[9]);
            }
            if (sumIndex13 != 0)
            {
                redChiSum += (subtractedSumIndex13 * subtractedSumIndex13) / (userInputPicture[13] + databasePicture[13]);
            }

            redChiValue =  Math.Sqrt(redChiSum)/4.0;

            //////////////////////////////////////////////////////////
            ///////////////////////GREEN SECTION//////////////////////
            //////////////////////////////////////////////////////////

            //top part of each sub-task in the whole sum
            double substractedSumIndex2 = userInputPicture[2] - databasePicture[2];
            double subtractedSumIndex6 = userInputPicture[6] - databasePicture[6];
            double subtractedSumIndex10 = userInputPicture[10] - databasePicture[10];
            double subtractedSumIndex14 = userInputPicture[14] - databasePicture[14];

            //bottom part of each sub-task in the whole sum
            double sumIndex2 = userInputPicture[2] + databasePicture[2];
            double sumIndex6 = userInputPicture[6] + databasePicture[6];
            double sumIndex10 = userInputPicture[10] + databasePicture[10];
            double sumIndex14 = userInputPicture[14] + databasePicture[14];


            if (sumIndex2 != 0)
            {
                //square                                        //addition
                greenChiSum += (substractedSumIndex2 * substractedSumIndex2) / (sumIndex2);
            }

            if (sumIndex6 != 0)
            {
                greenChiSum += (subtractedSumIndex6 * subtractedSumIndex6) / (sumIndex6);
            }
                if (sumIndex10 != 0)
            {
                greenChiSum += (subtractedSumIndex10 * subtractedSumIndex10) / (sumIndex10);
            }
            if (sumIndex14 != 0)
            {
                greenChiSum += (subtractedSumIndex14 * subtractedSumIndex14) / (sumIndex14);
            }

            greenChiValue = ( (1 / 4.0) * ( Math.Sqrt(greenChiSum) ) );

            /////////////////////////////////////////////////////////
            ///////////////////////BLUE SECTION//////////////////////
            /////////////////////////////////////////////////////////


            double substractedSumIndex3 = userInputPicture[3] - databasePicture[3];
            double subtractedSumIndex7 = userInputPicture[7] - databasePicture[7];
            double subtractedSumIndex11 = userInputPicture[11] - databasePicture[11];
            double subtractedSumIndex15 = userInputPicture[15] - databasePicture[15];

            //bottom part of each sub-task in the whole sum
            double sumIndex3 = userInputPicture[3] + databasePicture[3];
            double sumIndex7 = userInputPicture[7] + databasePicture[7];
            double sumIndex11 = userInputPicture[11] + databasePicture[11];
            double sumIndex15 = userInputPicture[15] + databasePicture[15];


            if (sumIndex3 != 0)
            {
                //square                                        //addition
                blueChiSum += (substractedSumIndex3 * substractedSumIndex3) / (sumIndex3);
            }

            if (sumIndex7 != 0)
            {
                blueChiSum += (subtractedSumIndex7 * subtractedSumIndex7) / (sumIndex7);
            }
            if (sumIndex11 != 0)
            {
                blueChiSum += (subtractedSumIndex11 * subtractedSumIndex11) / (sumIndex11);
            }
            if (sumIndex15 != 0)
            {
                blueChiSum += (subtractedSumIndex15 * subtractedSumIndex15) / (sumIndex15);
            }

            blueChiValue = ((1 / 4.0) * (Math.Sqrt(blueChiSum)));


            ////////////////////////////CALCULATING FINAL SUM////////////////////////

            finalChiValue = (1 / 3.0) * (redChiValue + greenChiValue + blueChiValue);


            return finalChiValue;
        }

    }
}
