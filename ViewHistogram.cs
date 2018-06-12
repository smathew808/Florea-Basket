using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace CS325_broadSword_flowerProject
{
    public partial class ViewHistogram : Form
    {
     
        ViewHistogramController HistogramController = new ViewHistogramController();
        //test values
        private const int MIN_VALUE = 0;
        private const int MAX_VALUE = 15;

        ViewHistogramController HistoGuiController;

        //test list
        int[] redTestList = new int[] { 255, 1, 87, 54, 169 };
        int[] greenTestList = new int[] { 102, 6, 54, 96, 34 };
        int[] blueTestList = new int[] { 123, 145, 67, 0, 86 };

        //public int[] RGBList = new int[17];
        int[] testRGBList = new int[17] { 0, 5, 5, 4, 0, 7, 4, 3, 0, 4, 4, 25, 0, 18, 25, 10, 0 };

        //the constructor might expect an int id for the flower so it can tell the DBMgr to find the right flower?
        public ViewHistogram(ViewHistogramController controller)
        {

            InitializeComponent();

            

            HistoGuiController = controller;
           
        }

       

        // Draw the histogram.
        private void picHisto_Paint(object sender, PaintEventArgs e)
        {
            
            // HistogramPicture is the picturebox
            DrawHistogram(e.Graphics, this.BackColor, testRGBList,
                this.HistogramPicture.Width, this.HistogramPicture.Height);
        }

        // Redraw.
        private void picHisto_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }

        // Draw a histogram.
        private void DrawHistogram(Graphics gr, Color back_color,
            int[] RGBList, int width, int height)
        {

            HistogramController.ControllerDrawHistogram( gr, back_color,
            RGBList, width,height);
        }   

    }
}
