using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    public class Box
    {
        private int length, width, height;

        public Box(int length, int width, int height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public int calcPerimeter()
        {
            int perim = (2 * length) + (2 * width);
            return perim;
        }

        public int calcArea()
        {
            int area = length * width;
            return area;
        }

        public int calcVolume()
        {
            int volume = length * width * height;
            return volume;
        }
    }
}
