using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace interview_02
{
    /*public  class ImageFilter
    {

        public  Image FilteredImage_Red(Image inputImage)
        {
            Bitmap bmap = (Bitmap)inputImage;
            Bitmap temp = (Bitmap)bmap.Clone();
            Color c;
            for (int i = 0; i < temp.Width; i++)
            {
                for (int j = 0; j < temp.Height; j++)
                {
                    c = temp.GetPixel(i, j);
                    int nPixelR = 0;
                    int nPixelG = 0;
                    int nPixelB = 0;

                    nPixelR = c.R - 255;
                    nPixelG = c.G;
                    nPixelB = c.B;

                    nPixelR = Math.Max(nPixelR, 0);
                    nPixelR = Math.Min(255, nPixelR);

                    nPixelG = Math.Max(nPixelG, 0);
                    nPixelG = Math.Min(255, nPixelG);

                    nPixelB = Math.Max(nPixelB, 0);
                    nPixelB = Math.Min(255, nPixelB);

                    temp.SetPixel(i, j, Color.FromArgb((byte)nPixelR,
                      (byte)nPixelG, (byte)nPixelB));
                }
            }

            return temp;
        }

        public  Image FilteredImage_Gray(Image inputImage)
        {
            Bitmap bmap = (Bitmap)inputImage;
            Bitmap temp = (Bitmap)bmap.Clone();
            Color c;
            for (int i = 0; i < temp.Width; i++)
            {
                for (int j = 0; j < temp.Height; j++)
                {
                    c = temp.GetPixel(i, j);
                    int nPixelR = 0;
                    int nPixelG = 0;
                    int nPixelB = 0;
                    int nPixelGray = 0;

                    nPixelR = c.R;
                    nPixelG = c.G;
                    nPixelB = c.B;


                    //Average
                    //nPixelGray = (nPixelR + nPixelG + nPixelB) / 3;


                    //Median
                    if (nPixelR > nPixelG && nPixelG > nPixelB || nPixelB > nPixelG && nPixelG > nPixelR)
                    {
                        nPixelGray = nPixelG;
                    }
                    else if (nPixelG > nPixelB && nPixelB > nPixelR || nPixelR > nPixelB && nPixelB > nPixelG)
                    {
                        nPixelGray = nPixelB;
                    }
                    else if (nPixelG > nPixelR && nPixelR > nPixelB || nPixelB > nPixelR && nPixelR > nPixelG)
                    {
                        nPixelGray = nPixelR;
                    }


                    //Max value for Dark Gray tone
                    //if (nPixelR > nPixelG && nPixelR > nPixelB )
                    //{
                    //    nPixelGray = nPixelR;
                    //}
                    //else if (nPixelG > nPixelB && nPixelG > nPixelR )
                    //{
                    //    nPixelGray = nPixelG;
                    //}
                    //else if (nPixelB > nPixelR && nPixelB > nPixelG )
                    //{
                    //    nPixelGray = nPixelB;
                    //}


                    //Min value for Light Gray tone 
                    //if (nPixelR < nPixelG && nPixelR < nPixelB)
                    //{
                    //    nPixelGray = nPixelR;
                    //}
                    //else if (nPixelG < nPixelB && nPixelG < nPixelR)
                    //{
                    //    nPixelGray = nPixelG;
                    //}
                    //else if (nPixelB < nPixelR && nPixelB < nPixelG)
                    //{
                    //    nPixelGray = nPixelB;
                    //}

                    nPixelGray = Math.Max(nPixelGray, 0);
                    nPixelGray = Math.Min(255, nPixelGray);

                    temp.SetPixel(i, j, Color.FromArgb((byte)nPixelGray,
                      (byte)nPixelGray, (byte)nPixelGray));
                }
            }

            return temp;
        }

        public  Image MovingAverageFilter(Image inputImage)
        {
            Bitmap bmap = (Bitmap)inputImage;
            Bitmap temp = (Bitmap)bmap.Clone();
            int N = 3;
            int size = N * N;       

            Color c;
            int x = 0; int y = 0;
            for (int i = 0; i < temp.Width; i++)
            {
                for (int j = 0; j < temp.Height; j++)
                {
                    int averageR = 0;
                    int averageG = 0;
                    int averageB = 0;
                  
                    for (int m = 0; m <N ; m++)
                    {
                        x = m - (N / 2);
                        for (int n = 0; n < N; n++)
                        {
                            y = n - (N / 2);
                            if ((0 <= (i + x) && (i + x) < temp.Width) && (0 <= (j + y) && (j + y) < temp.Height))
                            {
                                if (Math.Abs(x) != Math.Abs(y))
                                {
                                    c = temp.GetPixel(i + x, j + y);
                                    averageR += c.R / (size-4);
                                    averageG += c.G / (size-4);
                                    averageB += c.B / (size-4);
                                }
                            }
                           
                        }
                    }

                    temp.SetPixel(i, j, Color.FromArgb((byte)averageR,
                      (byte)averageG, (byte)averageB));
                    
                }
            }

            return Normalize(temp);
        }

        public  Image Normalize(Image inputImage)
        {
            Bitmap bmap = (Bitmap)inputImage;
            Bitmap temp = (Bitmap)bmap.Clone();
            Color c;
            int maxR = -10000;
            int maxG = -10000;
            int maxB = -10000;
            int minR = 10000;
            int minG = 10000;
            int minB = 10000;
            for (int i = 0; i < temp.Width; i++)
            {
                for (int j = 0; j < temp.Height; j++)
                {
                    c = temp.GetPixel(i, j);
                    maxR = Math.Max(maxR, c.R);
                    maxG = Math.Max(maxG, c.G);
                    maxB = Math.Max(maxB, c.B);
                    minR = Math.Min(minR, c.R);
                    minG = Math.Min(minG, c.G);
                    minB = Math.Min(minB, c.B);
                }
            }
            

            for (int i = 0; i < temp.Width; i++)
            {
                for (int j = 0; j < temp.Height; j++)
                {
                    c = temp.GetPixel(i, j);
                    temp.SetPixel(i, j, Color.FromArgb((byte)((255*(c.R-minR))/(maxR-minR)),
                       (byte)((255 * (c.G - minG)) / (maxG - minG)), (byte)((255 * (c.B - minB)) / (maxB - minB))));
                }
            }
            return temp;
        }
        

    }*/
}
