using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filter;
namespace _02_BitmapPlayground.Filters
{
    public class GrayscaleFilter : IFilter
    {
        public string Name => "Grayscale Filter";
        public override string ToString()
        {
            return Name;
        }

        public Color[,] Apply(Color[,] input)
        {
            int width = input.GetLength(0);
            int height = input.GetLength(1);
            Color[,] result = new Color[width, height];

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    int grayP = 0;
                    var p = input[x, y];
                    grayP = (p.R + p.G + p.B)/3;

                    //i used average. there are median,max value of rgb (for dark gray) and min value of rgb(for light gray).

                    result[x, y] = Color.FromArgb(p.A, grayP, grayP, grayP);
                }
            }

            return result;
        }
    }
}
