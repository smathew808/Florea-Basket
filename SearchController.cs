using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS325_broadSword_flowerProject
{
    public class SearchController
    {
        private Flower[] flowerArray;
        private int numberOfFlowersInArray = 0;
        private String userMessage = "Your search did not return any flowers.\n";
        private bool databaseSearched = false;
        public SearchController(String englishNameToSearch, bool incompleteEnglishName, String latinNameToSearch, bool incompleteLatinName, String botanicalFamilyToSearch, bool incompleteBotanical, String dateOfEntryToSearch)
        {

            flowerArray = new Flower[Flower.getNumberOfRecords()];
            if (englishNameToSearch != null)
            {
                if (!(databaseSearched && numberOfFlowersInArray == 0)) // check to make sure that we haven't come up empty already in the database
                {
                    if (incompleteEnglishName)
                    {
                        numberOfFlowersInArray = Search.partialEnglishName(englishNameToSearch, ref flowerArray, numberOfFlowersInArray);
                    }
                    else
                    {
                        numberOfFlowersInArray = Search.fullEnglishName(englishNameToSearch, ref flowerArray, numberOfFlowersInArray);
                    }
                    databaseSearched = true;
                } // end check if the database has been searched.
            }
            if (latinNameToSearch != null)
            {
                if (!(databaseSearched && numberOfFlowersInArray == 0))
                {
                    if (incompleteLatinName)
                        numberOfFlowersInArray = Search.partialLatinName(latinNameToSearch, ref flowerArray, numberOfFlowersInArray);
                    else
                        numberOfFlowersInArray = Search.fullLatinName(latinNameToSearch, ref flowerArray, numberOfFlowersInArray);
                    databaseSearched = true;
                } // end check if the database has been searched
            }
            if (botanicalFamilyToSearch != null)
            {
                if (!(databaseSearched && numberOfFlowersInArray == 0))
                {
                    if (incompleteBotanical)
                        numberOfFlowersInArray = Search.partialBotanicalName(botanicalFamilyToSearch, ref flowerArray, numberOfFlowersInArray);
                    else
                        numberOfFlowersInArray = Search.fullBotanicalName(botanicalFamilyToSearch, ref flowerArray, numberOfFlowersInArray);
                    databaseSearched = true;
                }
            }
            if (dateOfEntryToSearch != null)
            {
                if (!(databaseSearched && numberOfFlowersInArray == 0))
                {
                    numberOfFlowersInArray = Search.dateSearch(dateOfEntryToSearch, ref flowerArray, numberOfFlowersInArray);
                    databaseSearched = true;
                }
            }
            if (numberOfFlowersInArray != 0)
            {
                userMessage = "Search Results: \n";
            }
        } // end SearchController constructor


        public Flower[] getArray()
        {
            return flowerArray;
        }

        public int getNumberOfFlowersInArray()
        {
            return numberOfFlowersInArray;
        }

        public String getMessage()
        {
            return userMessage;
        }
    } // end class
} // end namespace