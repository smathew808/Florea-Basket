using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace CS325_broadSword_flowerProject
{
    public class Picture
    {
        private Image pictureImage;
        private Note note;
        private string path;
        private int[] singlePictureBinList;

        public Picture(Image picture, DateTime timeDate, String photographer, String location, String note, string path, int[] singlePictureBinList)
        {
            this.pictureImage = Image.FromFile(path);
            this.note = new Note(timeDate, note, photographer, location);
            this.path = path;
            this.singlePictureBinList = singlePictureBinList;
        }

        public Picture(DateTime timeDate, String photographer, String location, String note, string path)
        {
            this.pictureImage = Image.FromFile(path);
            this.note = new Note(timeDate, note, photographer, location);
            this.path = path;
        }

        public int[] getBinList()
        {
            return this.singlePictureBinList;
        }

        public Image getPicture()
        {
            return pictureImage;
        }

        public DateTime getTimeDate()
        {
            return note.getTimeDate();
        }

        public String getPhotographer()
        {
            return note.getPhotographer();
        }

        public String getLocation()
        {
            return note.getLocation();
        }

        public String getNote()
        {
            return note.getNote();
        }

        public String getPath()
        {
            return path;
        }
    }

}
