using Microsoft.VisualStudio.TestTools.UnitTesting;
using CS325_broadSword_flowerProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS325_broadSword_flowerProject.Tests
{
    [TestClass()]
    public class SearchFlowerLanguageControllerTests
    {
        //SearchFlowerLanguageController searchFlowerObject;

        [TestMethod()]
        public void SearchFlowerLanguageControllerTest()
        {
        }

        [TestMethod()]
        public void getSearchListTest()
        {


            //arrange

            //test searchTypeInput

            int inputEnglishName = 0;
            int inputLatinName = 1;
            int BotanicalFamily = 2;

            
            //testing with words that have accidental words in them
            //perfect is when you spell it correctly

            //string length tests
            string inputEnglishNameRosePerfect = "rose";
            string inputEnglishNameRoseBigger = "roseee";
            string intputEnglishNameRoseSmaller = "ros";

            
            //test inputs that will test case-sensitivity
            string inputEnglishNameRosePerfectUpperCase = "Rose";
            string inputEnglishNameRoseBiggerUpperCase = "rOsEee";
            string intputEnglishNameRoseSmallerUpperCase = "RoS";

            //test inputs for typos in the intended word to be searched for
            string inputEnglishNameRoseTypo1 = "rtse";
            string inputEnglishNameRoseTypo2 = "rogttt";
            string inputEnglishNameRoseTypo3 = "rgghdg"; 


            //add expected input from DB, which will be Rose with an int ID value of 0, and Daisy which will be an int ID value of 1
            List<int> successListRose= new List<int>();
            successListRose.Add(0);//Rose


            List<int> successList2 = new List<int>();
            successList2.Add(1);//Daisy
            

            //this list will remain empty
            List<int> noResultsTest = new List<int>();

            //Act
           


           //these set of tests will determine if the search will still find the word "rose"
          // List<int> perfectTest = searchFlowerObject.getSearchList(inputEnglishName, inputEnglishNameRosePerfect);

          

        }

        [TestMethod()]
        public void computeSearchTest()
        {
            //this test will determine whether or not the word rose will be found. 

            //arrange

            //test searchTypeInput

            int inputEnglishName = 0;
            int inputLatinName = 1;
            int BotanicalFamily = 2;


            //testing with words that have accidental words in them
            //perfect is when you spell it correctly

            //string length tests
            string inputEnglishNameRosePerfect = "rose";
            string inputEnglishNameRoseBigger = "roseee";
            string intputEnglishNameRoseSmaller = "ros";


            //test inputs that will test case-sensitivity
            string inputEnglishNameRosePerfectUpperCase = "Rose";
            string inputEnglishNameRoseBiggerUpperCase = "rOsEee";
            string intputEnglishNameRoseSmallerUpperCase = "RoS";

            //test inputs for typos in the intended word to be searched for
            string inputEnglishNameRoseTypo1 = "rtse";
            string inputEnglishNameRoseTypo2 = "rhgt";
            string inputEnglishNameRoseTypo3 = "rog";


            //add expected input from DB, which will be Rose with an int ID value of 0, and Daisy which will be an int ID value of 1
            List<Tuple<int, string>> successListRose = new List<Tuple<int, string>>();
            successListRose.Add(new Tuple<int, string>(1, "rose"));//Rose
            //successListRose.Add(new Tuple<int, string>(2, "Daisy"));//Daisy

            //this list will remain empty
            List<int> noResultsTest = new List<int>();

            //expected output
            List<int> foundRose = new List<int>();
            foundRose.Add(1);

            SearchFlowerLanguageController searchFlowerObject = new SearchFlowerLanguageController();
            //Act
            //SearchFlowerLanguageGUI guiobject = new SearchFlowerLanguageGUI(searchFlowerObject);

          

            //Assert

            //*******************//
            //test size of string//
            //*******************//


            //these set of tests will determine if the search will still find the word "rose"
            List<int> perfectTest = searchFlowerObject.computeSearch(successListRose, inputEnglishNameRosePerfect);

            for (int i = 0; i < successListRose.Count; i++)
                Assert.AreEqual(foundRose[i], perfectTest[i]);

            //these set of tests will determine if the search will still find the word "rose"

            //List<int> biggerTest = searchFlowerObject.computeSearch(successListRose, inputEnglishNameRoseBigger);

            //for (int i = 0; i < successListRose.Count; i++)
            //    Assert.AreEqual(foundRose[i], biggerTest[i]);

            List<int> smallerTest = searchFlowerObject.computeSearch(successListRose, intputEnglishNameRoseSmaller);

            for (int i = 0; i < successListRose.Count; i++)
                Assert.AreEqual(foundRose[i], smallerTest[i]);

            //********************//
            //test case sensitivty//
            //********************//

            //List<int> perfectUpperCase = searchFlowerObject.computeSearch(successListRose, inputEnglishNameRosePerfectUpperCase);

            //for (int i = 0; i < successListRose.Count; i++)
            //    Assert.AreEqual(foundRose[i], perfectUpperCase[i]);

            //List<int> biggerUpperCase = searchFlowerObject.computeSearch(successListRose, inputEnglishNameRoseBiggerUpperCase);

            //for (int i = 0; i < successListRose.Count; i++)
            //    Assert.AreEqual(foundRose[i], biggerUpperCase[i]);

            //List<int> smallerUpperCase = searchFlowerObject.computeSearch(successListRose, intputEnglishNameRoseSmallerUpperCase);

            //for (int i = 0; i < successListRose.Count; i++)
            //    Assert.AreEqual(foundRose[i], smallerUpperCase[i]);

            //********************//
            //test case for typos*//
            //********************//

            List<int> typo1Test = searchFlowerObject.computeSearch(successListRose, inputEnglishNameRoseTypo1);

            for (int i = 0; i < successListRose.Count; i++)
                Assert.AreEqual(foundRose[i], typo1Test[i]);

            List<int> typo2Test = searchFlowerObject.computeSearch(successListRose, inputEnglishNameRoseTypo2);

            for (int i = 0; i < successListRose.Count; i++)
                Assert.AreEqual(foundRose[i], typo2Test[i]);

            List<int> typo3Test = searchFlowerObject.computeSearch(successListRose, inputEnglishNameRoseTypo3);

            for (int i = 0; i < successListRose.Count; i++)
                Assert.AreEqual(foundRose[i], typo3Test[i]);



        }
    }
}