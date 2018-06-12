using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS325_broadSword_flowerProject
{
    public class Search
    {
        private static DatabaseManager db = new DatabaseManager();
        // dateSearch method to search for a date Added
        public static int dateSearch(String dateOfEntryToSearch, ref Flower[] flowerArray, int numberOfFlowersInArray)
        {
            // The array is empty, so start in the database.
            if (numberOfFlowersInArray == 0)
            {
                flowerArray = new Flower[Flower.getNumberOfRecords()];
                foreach (Flower f in db.getDatabase())
                {
                    if (dateOfEntryToSearch.Equals(f.getDateAdded()))
                    {
                        flowerArray[numberOfFlowersInArray] = new Flower(f);
                        numberOfFlowersInArray++;
                    } // end if equals
                } // end foreach
            } // end if 

            // The array is already populated, so search through it
            else
            {
                Flower[] temp = new Flower[numberOfFlowersInArray];
                int numTempFlowers = 0;
                for (int i = 0; i < numberOfFlowersInArray; i++)
                {
                    if (dateOfEntryToSearch.Equals(flowerArray[i].getDateAdded()))
                    {
                        temp[numTempFlowers] = new Flower(flowerArray[i]);
                        numTempFlowers++;
                    } // end if equals
                } // end flowerArray traversal
                flowerArray = temp;
                numberOfFlowersInArray = numTempFlowers;
            } // end else
            flowerArray = resizeArray(flowerArray, numberOfFlowersInArray); // resize the array so there isn't extra space.
            return numberOfFlowersInArray;
        } // end date search

        public static int fullEnglishName(String englishNameToSearch, ref Flower[] flowerArray, int numberOfFlowersInArray)
        {
            if (numberOfFlowersInArray == 0)
            {

                flowerArray = new Flower[Flower.getNumberOfRecords()];
                foreach (Flower f in db.getDatabase())
                {
                    if (englishNameToSearch.Equals(f.getEnglishName()))
                    {
                        flowerArray[numberOfFlowersInArray] = new Flower(f);
                        numberOfFlowersInArray++;
                    } // end if equals
                } // end foreach

            } // end if
            else
            {
                Flower[] temp = new Flower[numberOfFlowersInArray];
                int numFlowersInTempArray = 0;
                for (int i = 0; i < numberOfFlowersInArray; i++)
                {
                    if (englishNameToSearch.Equals(flowerArray[i].getEnglishName()))
                    {
                        temp[numFlowersInTempArray] = flowerArray[i];
                        numFlowersInTempArray++;
                    } // end if equals
                } // end for
                flowerArray = temp;
                numberOfFlowersInArray = numFlowersInTempArray;
            } // end Else
            flowerArray = resizeArray(flowerArray, numberOfFlowersInArray); // resize the array so there isn't extra space.
            return numberOfFlowersInArray;
        } // end searchFullEnglishName

        public static int partialEnglishName(String englishNameToSearch, ref Flower[] flowerArray, int numberOfFlowersInArray)
        {
            if (numberOfFlowersInArray == 0)
            {
                flowerArray = new Flower[Flower.getNumberOfRecords()];
                foreach (Flower f in db.getDatabase())
                {
                    if (f.getEnglishName().Contains(englishNameToSearch))
                    {
                        flowerArray[numberOfFlowersInArray] = new Flower(f);
                        numberOfFlowersInArray++;
                    } // end if equals
                } // end foreach
            } // end first search if
            else
            {
                Flower[] temp = new Flower[numberOfFlowersInArray];
                int numFlowersInTempArray = 0;
                for (int i = 0; i < numberOfFlowersInArray; i++)
                {
                    if (flowerArray[i].getEnglishName().Contains(englishNameToSearch))
                    {
                        temp[numFlowersInTempArray] = new Flower(flowerArray[i]);
                        numFlowersInTempArray++;
                    } // end if equals
                } // end for
                flowerArray = temp;
                numberOfFlowersInArray = numFlowersInTempArray;
            } // end else

            flowerArray = resizeArray(flowerArray, numberOfFlowersInArray); // resize the array so there isn't extra space.
            return numberOfFlowersInArray;

        } // end searchPartialEnglishName

        public static int fullLatinName(String latinNameToSearch, ref Flower[] flowerArray, int numberOfFlowersInArray)
        {
            if (numberOfFlowersInArray == 0)
            {
                flowerArray = new Flower[Flower.getNumberOfRecords()];
                foreach (Flower f in db.getDatabase())
                {
                    if (latinNameToSearch.Equals(f.getLatinName()))
                    {
                        flowerArray[numberOfFlowersInArray] = f;
                        numberOfFlowersInArray++;
                    } // end if equals
                } // end foreach

            } // end if
            else
            {
                Flower[] temp = new Flower[numberOfFlowersInArray];
                int numFlowersInTempArray = 0;
                for (int i = 0; i < numberOfFlowersInArray; i++)
                {
                    if (latinNameToSearch.Equals(flowerArray[i].getLatinName()))
                    {
                        temp[numFlowersInTempArray] = flowerArray[i];
                        numFlowersInTempArray++;
                    } // end if equals
                } // end for
                flowerArray = temp;
                numberOfFlowersInArray = numFlowersInTempArray;
            } // end else
            flowerArray = resizeArray(flowerArray, numberOfFlowersInArray); // resize the array so there isn't extra space.
            return numberOfFlowersInArray;
        } // end searchFullLatinName

        public static int partialLatinName(String latinNameToSearch, ref Flower[] flowerArray, int numberOfFlowersInArray)
        {
            if (numberOfFlowersInArray == 0)
            {
                flowerArray = new Flower[Flower.getNumberOfRecords()];
                foreach (Flower f in db.getDatabase())
                {
                    if (f.getLatinName().Contains(latinNameToSearch))
                    {
                        flowerArray[numberOfFlowersInArray] = new Flower(f);
                        numberOfFlowersInArray++;
                    } // end if equals
                } // end foreach
            } // end first search if
            else
            {
                Flower[] temp = new Flower[numberOfFlowersInArray];
                int numFlowersInTempArray = 0;
                for (int i = 0; i < numberOfFlowersInArray; i++)
                {

                    if (flowerArray[i].getLatinName().Contains(latinNameToSearch))
                    {
                        temp[numFlowersInTempArray] = new Flower(flowerArray[i]);
                        numFlowersInTempArray++;
                    } // end if equals
                } // end for
                flowerArray = temp;
                numberOfFlowersInArray = numFlowersInTempArray;
            } // end else
            flowerArray = resizeArray(flowerArray, numberOfFlowersInArray); // resize the array so there isn't extra space.
            return numberOfFlowersInArray;
        } // end searchPartialLatinName

        public static int fullBotanicalName(String botanicalFamilyToSearch, ref Flower[] flowerArray, int numberOfFlowersInArray)
        {
            if (numberOfFlowersInArray == 0)
            {
                flowerArray = new Flower[Flower.getNumberOfRecords()];
                foreach (Flower f in db.getDatabase())
                {
                    if (botanicalFamilyToSearch.Equals(f.getBotanicalFamily()))
                    {
                        flowerArray[numberOfFlowersInArray] = f;
                        numberOfFlowersInArray++;
                    } // end if equals
                } // end foreach
            } // end if
            else
            {
                Flower[] temp = new Flower[numberOfFlowersInArray];
                int numFlowersInTempArray = 0;
                for (int i = 0; i < numberOfFlowersInArray; i++)
                {
                    if (botanicalFamilyToSearch.Equals(flowerArray[i].getBotanicalFamily()))
                    {
                        temp[numFlowersInTempArray] = flowerArray[i];
                        numFlowersInTempArray++;
                    } // end if equals
                } // end for
                flowerArray = temp;
                numberOfFlowersInArray = numFlowersInTempArray;
            } // end else
            flowerArray = resizeArray(flowerArray, numberOfFlowersInArray); // resize the array so there isn't extra space.
            return numberOfFlowersInArray;
        } // end searchFullBotanicalFamily

        public static int partialBotanicalName(String botanicalFamilyToSearch, ref Flower[] flowerArray, int numberOfFlowersInArray)
        {
            if (numberOfFlowersInArray == 0)
            {
                flowerArray = new Flower[Flower.getNumberOfRecords()];
                foreach (Flower f in db.getDatabase())
                {
                    if (f.getBotanicalFamily().Contains(botanicalFamilyToSearch))
                    {
                        flowerArray[numberOfFlowersInArray] = new Flower(f);
                        numberOfFlowersInArray++;
                    } // end if equals
                } // end foreach
            } // end if
            else
            {
                Flower[] temp = new Flower[numberOfFlowersInArray];
                int numFlowersInTempArray = 0;
                for (int i = 0; i < numberOfFlowersInArray; i++)
                {
                    if (flowerArray[i].getBotanicalFamily().Contains(botanicalFamilyToSearch))
                    {
                        temp[numFlowersInTempArray] = new Flower(flowerArray[i]);
                        numFlowersInTempArray++;
                    } // end if equals
                } // end for
                flowerArray = temp;
                numberOfFlowersInArray = numFlowersInTempArray;
            } // end else
            flowerArray = resizeArray(flowerArray, numberOfFlowersInArray); // resize the array so there isn't extra space.
            return numberOfFlowersInArray;
        } // end searchPartialBotanicalFamily
        public static Flower[] resizeArray(Flower[] array, int numInArray)
        {
            if (numInArray != 0)
            {
                Flower[] newArray = new Flower[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = new Flower(array[i]);
                }
                array = new Flower[numInArray];
                for (int i = 0; i < numInArray; i++)
                {
                    array[i] = new Flower(newArray[i]);
                } // end for
            } // end if
            return array;
        } // end resizeArray

    } // end class

} // end namespace
