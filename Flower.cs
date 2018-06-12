using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS325_broadSword_flowerProject
{
    public class Flower
    {
        private static int numberOfRecords;
        private String englishName;
        private String latinName;
        private String botanicalFamily;
        private Note note;
        private int ID;

        public List<Picture> pictureList = new List<Picture>();

        public Flower(String latin, String english, String family, Note note)
        {
            numberOfRecords++;
            this.note = note;
            englishName = english;
            latinName = latin;
            botanicalFamily = family;
        }
        public static int getNumberOfRecords() { return numberOfRecords; }
       // public String getDateAdded() { return note.getDateAdded(); }
        public String getEnglishName() { return englishName; }
        public String getLatinName() { return latinName; }
        public String getBotanicalFamily() { return botanicalFamily; }
        public Note getNote() { return note; }
        public int getID() { return ID; }

        public void setEnglishName(string name)
        {
            this.englishName = name;
        }

        public void setLatinName(string name)
        {
            this.latinName = name;
        }

        public void setbotanicalFamily(string family)
        {
            this.botanicalFamily = family;
        }

        public void setNote(Note note)
        {
            this.note = note;
        }

        public void setID(int ID)
        {
            this.ID = ID;
        }

        public Flower(Flower toBeCopied)
        {
            if (toBeCopied != null)
            {
                this.note = toBeCopied.note;
                this.englishName = toBeCopied.englishName;
                this.latinName = toBeCopied.latinName;
                this.botanicalFamily = toBeCopied.botanicalFamily;
            }
        }
    } // end class
} // end namespace
