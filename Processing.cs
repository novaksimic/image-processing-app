using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imageprocessor
{
    class Processing
    {
        

        public Processing()
        {


        }

        public static bool ConvertToGrayscale(Bitmap c)
        {


            int width = c.Width;
            int height = c.Height;

            Color s;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {

                    s = c.GetPixel(x, y);

                   
                    int a = s.A;
                    int r = s.R;
                    int g = s.G;
                    int b = s.B;

                    
                    int avg = (r + g + b) / 3;

                  
                    c.SetPixel(x, y, Color.FromArgb(a, avg, avg, avg));

                }

            }

            return true;
        }



        public static bool ConvertToNegative(Bitmap b)
        {


            int width = b.Width;
            int height = b.Height;

            Color s;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {

                    s = b.GetPixel(x, y);

                   
                    int a = s.A;
                    int r1 = s.R;
                    int g1 = s.G;
                    int b1 = s.B;

                    r1 = 255 - r1;
                    g1 = 255 - r1;
                    b1 = 255 - r1;

               
                    b.SetPixel(x, y, Color.FromArgb(a, r1, g1, b1));

                }


            }




            return true;
        }


    }
}
