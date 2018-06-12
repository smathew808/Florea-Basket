using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CS325_broadSword_flowerProject
{


    //Developer: Sean Mathews
    //Objective: Create search functionality for string data types
    //Class: CS-325
    //Instructor: Mayer
    
    public class SearchFlowerLanguageController
    {


        //stubs is made here until integrated with database, meaning there will be additional
        //function calls or w/e 
        //int represents the DB int id that the DBM gives each flower, and the string value which can be either english, latin, or botanical name
        
        List<Tuple<int, string>> searchListEnglishName = new List<Tuple<int, string>>();
        List<Tuple<int, string>> searchListLatinName = new List<Tuple<int, string>>();
        List<Tuple<int, string>> searchListBotanicalFamily = new List<Tuple<int, string>>();

        //********user input********//

        //SearchType Stubs

        //**********************Dont need these stubs anymore************************//

        //string englishNameSearchTypeStub = "englishName";
        //string latinNameSearchTypeStub = "latinName";
        //string botanicalSearchTypeFamilyStub = "botanicalFamily";

        ////searchEntry Stubs
        //string englishNameSearchEntryStub1 = "Rose";
        //string englishNameSearhcEntryStub2 = "Daisy";

        //string latinNameSearchEntryStub1 = "RoseLatinName";
        //string latinNameSearhcEntryStub2 = "DaisyLatinName";

        //string botanicalFamilySearchEntryStub1 = "RoseBotanicalFamily";
        //string botanicalFamilySearhcEntryStub2 = "DaisyBotanicalFamily";

        public SearchFlowerLanguageController()
        {

        


            
            //all of these are part of the Stubs, will remove when dataBase is integrated
            
            //***********************Don't need these stubs anymore*************************//

            //replicates how output from dataBase will look like
            //adding EnglishName to stub
            //searchListEnglishName.Add(new Tuple<int, string>(1, "Rose"));
            //searchListEnglishName.Add(new Tuple<int, string>(2, "Daisy"));
            //searchListEnglishName.Add(new Tuple<int, string>(3, "Booty"));
            //searchListEnglishName.Add(new Tuple<int, string>(4, "Tooty"));
            //searchListEnglishName.Add(new Tuple<int, string>(5, "Rooty"));
            //searchListEnglishName.Add(new Tuple<int, string>(6, "Cooty"));

            ////adding LatinName to stub
            //searchListLatinName.Add(new Tuple<int, string>(1, "RoseLatinName"));
            //searchListLatinName.Add(new Tuple<int, string>(2, "DaisyLatinName"));
            //searchListLatinName.Add(new Tuple<int, string>(3, "BootyLatinName"));
            //searchListLatinName.Add(new Tuple<int, string>(4, "TootyLatinName"));
            //searchListLatinName.Add(new Tuple<int, string>(5, "RootyLatinName"));
            //searchListLatinName.Add(new Tuple<int, string>(6, "CootyLatinName"));


            ////adding botanicalFamily to stub
            //searchListBotanicalFamily.Add(new Tuple<int, string>(1, "RoseBotanicalFamily"));
            //searchListBotanicalFamily.Add(new Tuple<int, string>(2, "DaisyBotanicalFamily"));
            //searchListBotanicalFamily.Add(new Tuple<int, string>(3, "BootyBotanicalFamily"));
            //searchListBotanicalFamily.Add(new Tuple<int, string>(4, "TootyBotanicalFamily"));
            //searchListBotanicalFamily.Add(new Tuple<int, string>(5, "RootyBotanicalFamily"));
            //searchListBotanicalFamily.Add(new Tuple<int, string>(6, "CootyBotanicalFamily"));
        }

        internal void constructSearchGUI()
        {
            SearchFlowerGUI guiObject = new SearchFlowerGUI(this);
            guiObject.Show();
        }



        //********************function call that will calll for the DBM, will impliment after integrated with DB********************//
        // change the function type and return value when db is integrated
        public List<int> getSearchList(int SearchType, string SearchEntry)
        {
            // dbm function, just asking for searchType, with the corresponding DB int id for each flower
            //sql commands
            //i want to do an sql command to get the column of either the english names and corresponding int ids, latin names, and then worry about botanical families later
            //pass the dbm the searchtype which will be an int of 0(englishName), 1(latinName), 2(botanicalFamily), 3(Photo)for later

            //ask the dbm for the column list and return it to me
            //then ask the dbm list of int values and return them to me

            //  list reference = dbm blahbnlal

            //

            List<Tuple<int, string>> searchListFromDB = new List<Tuple<int, string>>();

            List<int> botanicalFlowerList = new List<int>();

            List<int> resultsList = new List<int>();

            //0 means get the latinName table with the corresponding int ids
            if (SearchType == 0)
            {
                searchListFromDB = DatabaseManager.getLatinNameList();
            }

            //1 means get the EnglishName table with the corresponding int ids
            else if (SearchType == 1)
            {
                searchListFromDB = DatabaseManager.getEnglishNameList();
            }

            //2 means get the BotanicalFamily talbe with the corresponding int ids
            else if (SearchType == 2)
            {
                   botanicalFlowerList = DatabaseManager.getBotanicalFamilyList(SearchEntry);


                //this returns the flower list because the DBM loops through the table to find each corresponding flower to the botanicalFamily searched for
                return botanicalFlowerList;
            }

           resultsList = computeSearch(searchListFromDB, SearchEntry);
            
            return resultsList; 
        }
        public List<int> computeSearch(List<Tuple<int, string>> SearchList, string SearchEntry)
        {
            //the list that will be returned to the DisplayResult UseCase
            //the list contains the ints that will
            List<int> searchResultList = new List<int>();



            //now that i got each possbile stub to use, now lets make some search entries so i can start comapring
            //ok i got the stubs, now i need to begin comparing if i find a match

            int equalString = SearchEntry.Length;

            //third one to decerement counter

            //search for stringName

            //****note****
            //the 2nd inner and out loop have the same 
            //this for loop executes up to the char length of the user's entry word

            for (int o = 0; o < SearchEntry.Length; o++) //worries about the how long the userEntry word is, for example the word "rose" will execute this for loop 4 times, because there are 4 chars 
            {
                for (int i = 0; i < SearchList.Count; i++) //this executes how big the list is from the DB
                {
                    //comparing between the entry that the user made and the english name from the db, if they are the same then add it to resultsList

                    // the number of times that the database string has to meet to the other 

                    int equalStringCounter = 0;

                    //purpose of forLoopBreaker is to check if program was checking a string that was already in the results list, because if it is, then it should skip it already since it checked it
                    int forLoopBreaker = 0;

                    //the length of the entry string
                    for (int c = 0; c < equalString; c++) //this executes how long the counter will be in order to find a word that will be added into the result list
                    {
                        //if the letter at index c(for example the first letter in a string would be index 0) in the string that user entered is the same as string pulled from database

                        //this for loop determines whether or not the word being currently compared is already in the list, if it is then break out of the "c" for loop
                        for (int j = 0; j < searchResultList.Count; j++)
                        {
                            if (searchResultList[j] == SearchList[i].Item1)
                            {
                                forLoopBreaker = 1;
                                break;
                            }
                        }

                        //to get out of the second for loop when the alg encounters a word already in the results list
                        if (forLoopBreaker == 1)
                        {
                            break;
                        }

                        //to check for when the searchEntry word is larger than the word in the DB
                        //if the current word counter is greater than the currently tested string than dont compare until they are of equal length at minimum
                        if (equalString > SearchList[i].Item2.Length )
                        {
                            break;
                        }

                            //checks if 2 chars in a string arent =, if they arent, then break out and go to the next word
                        if (SearchEntry[c] != SearchList[i].Item2[c])
                        {
                            break;
                        }


                        if (SearchEntry[c] == SearchList[i].Item2[c])
                        {
                            equalStringCounter++;
                        }
           
                        //checsk for perfect match
                        if (equalStringCounter == equalString)
                        {
                            searchResultList.Add(SearchList[i].Item1);
                        }

                    }


                   
                }

                equalString--;
                //at some point need to decrement counter

            }

            return searchResultList;
        }


        
    }
}
