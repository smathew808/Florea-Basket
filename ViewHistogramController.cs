using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace CS325_broadSword_flowerProject
{
   public class ViewHistogramController
    {

        //test values
        private const int COLOR_MIN_VALUE = 0;
        private const int COLOR_MAX_VALUE = 255;

        private const int MIN_VALUE = 0;
        private const int RECTANGLE_MAX_VALUE = 15;

        //initialize an RGBlistArray
       




        public ViewHistogramController()
        {
           
        }
        internal void constructHistoGUI()
        {
            ViewHistogram histoGuiObject = new ViewHistogram(this);
            histoGuiObject.Show();
        }


        public void ControllerDrawHistogram(Graphics gr, Color back_color,
            int[] RGBList, int width, int height)
        {
            //RGB array
            Color[] Colors = new Color[] { Color.Red, Color.Green, Color.Blue, };

            gr.Clear(back_color);

            // Make a transformation to the PictureBox.
            RectangleF data_bounds =
                new RectangleF(0, 0, RGBList.Length, RECTANGLE_MAX_VALUE);
            PointF[] points =
            {
        new PointF(0, height),
        new PointF(width, height),
        new PointF(0, 0)
    };
            Matrix transformation = new Matrix(data_bounds, points);
            gr.Transform = transformation;

            // Draw the histogram.
            using (Pen thin_pen = new Pen(Color.Black, 0))
            {
                for (int i = 0; i < RGBList.Length; i++)
                {
                    RectangleF rect = new RectangleF(i, 0, 1, RGBList[i]);
                    using (Brush the_brush =
                        new SolidBrush(Colors[i % Colors.Length]))
                    {
                        gr.FillRectangle(the_brush, rect);
                        gr.DrawRectangle(thin_pen, rect.X, rect.Y,
                            rect.Width, rect.Height);
                    }
                }
            }

            gr.ResetTransform();
            gr.DrawRectangle(Pens.Black, 0, 0, width - 1, height - 1);
        }


        
        //this temporarily fills the array with random data, but will soon take data from the server
        //this function will return three int arrays at the same time
        public int[] makeRGBList(List<Tuple<int,int,int>> colorList)
        {



             int[] RGBList = new int[17];

        //Random rnd = new Random();

        // This can randomly generate data for the lists
        //for (int i = 0; i < redList.Length; i++)
        //{ 
        //    //redList[i] = rnd.Next(COLOR_MIN_VALUE,COLOR_MAX_VALUE);
        //    //greenList[i] = rnd.Next(COLOR_MIN_VALUE, COLOR_MAX_VALUE);
        //   // blueList[i] = rnd.Next(COLOR_MIN_VALUE,COLOR_MAX_VALUE);
        //}

        //intitailize a list variable of type int
        var RGBSortedList = new List<int>();

            for (int i  = 0; i < colorList.Count; i ++)
            {
                // ******************************************* //
                // This portion of ifs handles RGB values 0-63 //
                // ******************************************* //

                ///////
                //red//
                ///////
                if ( (colorList[i].Item1 >= 0) && (colorList[i].Item1 <= 63))
                {
                    RGBList[1] = RGBList[1] + 1;
                }

                /////////
                //green//
                /////////
                if ((colorList[i].Item2 >= 0) && (colorList[i].Item2 <= 63))
                {
                    RGBList[2] = RGBList[2] + 1;
                }

               ////////
               //blue//
               ////////
                if ((colorList[i].Item3 >= 0) && (colorList[i].Item3 <= 63))
                {
                    RGBList[3] = RGBList[3] + 1;
                }

                // ********************************************* //
                // This portion of ifs handles RGB values 64-127 //
                // ********************************************* //


                if ((colorList[i].Item1 >= 64) && (colorList[i].Item1 <= 127))
                {
                    RGBList[5] = RGBList[5] + 1;
                }

                if ((colorList[i].Item2 >= 64) && (colorList[i].Item2 <= 127))
                {
                    RGBList[6] = RGBList[6] + 1;
                }

                if ((colorList[i].Item3 >= 64) && (colorList[i].Item3 <= 127))
                {
                    RGBList[7] = RGBList[7] + 1;
                }

                // ********************************************** //
                // This portion of ifs handles RGB values 128-191 //
                // ********************************************** //


                if ((colorList[i].Item1 >= 128) && (colorList[i].Item1 <= 191))
                {
                    RGBList[9] = RGBList[9] + 1;
                }

                if ((colorList[i].Item2 >= 128) && (colorList[i].Item2 <= 191))
                {
                    RGBList[10] = RGBList[10] + 1;
                }

                if ((colorList[i].Item3 >= 128) && (colorList[i].Item3 <= 191))
                {
                    RGBList[11] = RGBList[11] + 1;
                }

                // ********************************************** //
                // This portion of ifs handles RGB values 192-255 //
                // ********************************************** //


                if ((colorList[i].Item1 >= 192) && (colorList[i].Item1 <= 255))
                {
                    RGBList[13] = RGBList[13] + 1;
                }

                if ((colorList[i].Item2 >= 192) && (colorList[i].Item2 <= 255))
                {
                    RGBList[14] = RGBList[14] + 1;
                }

                if ((colorList[i].Item3 >= 192) && (colorList[i].Item3 <= 255))
                {
                    RGBList[15] = RGBList[15] + 1;
                }
            }

            //scaling for the histogram
            for (int i = 0; i < RGBList.Length; i++)
            {
                RGBList[i] = RGBList[i] / 1000;
            }
            
            return RGBList;
        }
    }
}
