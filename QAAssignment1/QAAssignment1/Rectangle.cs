using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAAssignment1
{
    class Rectangle
    {
        private int length;
        private int width;

        public Rectangle()
        {
            length = width = 1;
        }
        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }
        public int GetLength()
        {
            return this.length;
        }
        public int GetWidth()
        {
            return this.width;
        }
        public void SetLength(int length)
        {
            this.length = length;
        }
        public void SetWidth(int width)
        {
            this.width = width;
        }
        public int GetPerimeter()
        {
            return 2 * (length + width);
        }
        public int GetArea()
        {
            return length * width;
        }
    }
}
