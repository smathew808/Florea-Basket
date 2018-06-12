using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using IronPdf;
using System.IO;

namespace CS325_broadSword_flowerProject
{
    public class PrintToPDFController
    {
        public PrintToPDFController()
        {

        }

        //0=No error
        //1=Bad Path
        //2=Empty flower List
        //3=Unknown IO error
        public int createPDF(List<Flower> flowers, string filename)
        {
            int err = testFilename(filename);
            if(err != 0)
            {
                return err;
            }

            if(flowers.Count == 0)
            {
                return 2;
            }

            IronPdf.HtmlToPdf renderer = new IronPdf.HtmlToPdf();
            List<string> htmlList = new List<string>();

            for(int i = 0; i < flowers.Count; i++)
            {
                string flowerHTML = "Latin name: " + flowers[i].getLatinName() + "<br>";
                flowerHTML += "English name: " + flowers[i].getEnglishName() + "<br>";
                flowerHTML += "Botanical family: " + flowers[i].getBotanicalFamily() + "<br>";

                flowerHTML += "<br>Added on: " + flowers[i].getNote().getTimeDate().ToShortDateString() + " " + flowers[i].getNote().getTimeDate().ToShortTimeString() + "<br>";
                flowerHTML += flowers[i].getNote().getNote() + "<br>";

                for (int j = 0; j < flowers[i].pictureList.Count; j++)
                {
                    string pictureHTML = "<br><br><img src='"  + flowers[i].pictureList[j].getPath() + "'><br>";

                    pictureHTML += "Photographer: " + flowers[i].pictureList[j].getPhotographer() + "<br>";
                    pictureHTML += "Location: " + flowers[i].pictureList[j].getLocation() + "<br>";
                    pictureHTML += "Picture added on: " + flowers[i].pictureList[j].getTimeDate().ToShortDateString() + " " + flowers[i].pictureList[j].getTimeDate().ToShortTimeString() + "<br>";
                    pictureHTML += flowers[i].pictureList[j].getNote();

                    flowerHTML += pictureHTML;
                }

                htmlList.Add(flowerHTML);
            }

            string html = "";
            for(int i = 0; i < htmlList.Count; i++)
            {
                html += htmlList[i] + "<br><br><br>";
            }

            renderer.RenderHtmlAsPdf(html).SaveAs(filename);

            return 0;
        }

        private int testFilename(string filename)
        {
            try
            {
                System.IO.File.WriteAllText(filename, "TEST");
            }
            catch (ArgumentException e)
            {
                return 1;
            }
            catch (System.IO.IOException e)
            {
                return 1;
            }
            catch(Exception e)
            {
                return 3;
            }

            return 0;
        }
    }
}
