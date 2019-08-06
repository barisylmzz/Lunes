using Filter;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BitmapPlayground.Filters
{
    //3x3 matrices were taken to obtain 4 pixels.  Since the total 5 pixels will be processed, R G B values are divided by ​​(size-4).  The image was brighter or darker, while the image was desired to be blurred.  To resolve this problem, the Normalize () method was written.

    public class MovingAverageFilter : IFilter
    {
        public string Name => "Moving Average Filter";

        public override string ToString()
        {
            return Name;
        }

        public Color[,] Apply(Color[,] input)
        {
            int width = input.GetLength(0);
            int height = input.GetLength(1);
            Color[,] result = new Color[width, height];

            int N = 3;
            int size = N * N;
            int x = 0;
            int y = 0;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    

                    int averageR = 0;
                    int averageG = 0;
                    int averageB = 0;

                    for (int m = 0; m < N; m++)
                    {
                        x = m - (N / 2);
                        for (int n = 0; n < N; n++)
                        {
                            y = n - (N / 2);
                            if ((0 <= (i + x) && (i + x) < width) && (0 <= (j + y) && (j + y) < height))
                            {
                                if (Math.Abs(x) != Math.Abs(y))
                                {
                                    Color p = input[i+x, j+y];
                                    averageR += p.R / (size - 4);
                                    averageG += p.G / (size - 4);
                                    averageB += p.B / (size - 4);
                                    
                                }
                            }
                            
                        }
                    }
                    result[i, j] = Color.FromArgb(0, averageR, averageG, averageB);
                }
            }

            return Normalize(result);
        }

        public Color[,] Normalize(Color[,] input)
        {
            int width = input.GetLength(0);
            int height = input.GetLength(1);
            Color[,] result = new Color[width, height];

            int maxR = -10000;
            int maxG = -10000;
            int maxB = -10000;
            int minR = 10000;
            int minG = 10000;
            int minB = 10000;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    var p = input[i, j];
                    maxR = Math.Max(maxR, p.R);
                    maxG = Math.Max(maxG, p.G);
                    maxB = Math.Max(maxB, p.B);
                    minR = Math.Min(minR, p.R);
                    minG = Math.Min(minG, p.G);
                    minB = Math.Min(minB, p.B);
                    
                }
            }


            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    var p = input[i, j];

                    result[i, j] = Color.FromArgb((byte)((255 * (p.R - minR)) / (maxR - minR)),
                       (byte)((255 * (p.G - minG)) / (maxG - minG)), (byte)((255 * (p.B - minB)) / (maxB - minB)));

                }
            }
            return result;
        }


    }


}
