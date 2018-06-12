using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS325_broadSword_flowerProject
{
    public class Note
    {
        private DateTime timeDate;
        private String photographer;
        private String location;
        private String note;

        public Note(DateTime timeDate, String note, String photographer, String location)
        {
            this.timeDate = timeDate;
            this.note = note;
            this.photographer = photographer;
            this.location = location;
        }

        public Note(DateTime date, String note)
        {
            timeDate = date;
            this.note = note;
        }
        public DateTime getTimeDate()
        {
            return timeDate;
        }

        public string getNote()
        {
            return note;
        }
        public String getPhotographer()
        {
            return photographer;
        }

        public String getLocation()
        {
            return location;
        }
    }
}
