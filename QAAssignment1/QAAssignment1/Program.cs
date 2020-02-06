using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.SetLength(4);
            rect.SetWidth(8);
            Console.WriteLine("Length = "+rect.GetLength()+ "Width = "+rect.GetWidth()+" Area is "+rect.GetArea()+" Perimeter is "+rect.GetParameter());
            Console.ReadKey();
        }
    }
}
