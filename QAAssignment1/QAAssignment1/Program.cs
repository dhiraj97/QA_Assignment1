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

            int length, width, userChoice;
            bool flag;
            Rectangle rect = new Rectangle();

            Console.WriteLine("Please enter length of the rectangle");
            flag = int.TryParse(Console.ReadLine(), out length);
            while (length <= 0 || !flag)
            {
                Console.WriteLine("Please Enter valid Length");
                flag = int.TryParse(Console.ReadLine(), out length);
            }

            Console.WriteLine("Please enter width of the rectangle");
            flag = int.TryParse(Console.ReadLine(), out width);
            while (width <= 0 || !flag)
            {
                Console.WriteLine("Please Enter valid Width");
                flag = int.TryParse(Console.ReadLine(), out width);
            }
            rect.SetLength(length);
            rect.SetWidth(width);


            Console.WriteLine("1. Get Rectangle Length");
            Console.WriteLine("2. Change Rectangle Length");
            Console.WriteLine("3. Get Rectangle Width");
            Console.WriteLine("4. Change Rectangle Width");
            Console.WriteLine("5. Get Rectangle Perimeter");
            Console.WriteLine("6. Get Rectangle Area");
            Console.WriteLine("7. Exit");

            flag = int.TryParse(Console.ReadLine(), out userChoice);
            while (userChoice > 7 || userChoice < 1)
            {
                Console.WriteLine("Please select valid choice");
                Console.WriteLine("1. Get Rectangle Length");
                Console.WriteLine("2. Change Rectangle Length");
                Console.WriteLine("3. Get Rectangle Width");
                Console.WriteLine("4. Change Rectangle Width");
                Console.WriteLine("5. Get Rectangle Perimeter");
                Console.WriteLine("6. Get Rectangle Area");
                Console.WriteLine("7. Exit");
                flag = int.TryParse(Console.ReadLine(), out userChoice);
            }

            switch (userChoice)
            {
                case 1:
                    Console.WriteLine("Length of the Rectangle is " + rect.GetLength());
                    break;
                case 2:
                    Console.WriteLine("Please enter value for Length of the Rectangle");
                    flag = int.TryParse(Console.ReadLine(), out length);
                    while (length <= 0 || !flag)
                    {
                        Console.WriteLine("Please Enter valid Length");
                        flag = int.TryParse(Console.ReadLine(), out length);
                    }
                    rect.SetLength(length);
                    Console.WriteLine("Changed Length" +
                        " of the Rectangle is " + rect.GetLength());
                    break;
                case 3:
                    Console.WriteLine("Length of the Rectangle is " + rect.GetWidth());
                    break;
                case 4:
                    Console.WriteLine("Please enter value for Width of the Rectangle");
                    flag = int.TryParse(Console.ReadLine(), out width);
                    while (width <= 0 || !flag)
                    {
                        Console.WriteLine("Please Enter valid Width");
                        flag = int.TryParse(Console.ReadLine(), out width);
                    }
                    rect.SetWidth(width);
                    Console.WriteLine("Changed Width of the Rectangle is "+rect.GetWidth());
                    break;
                case 5:
                    Console.WriteLine("Perimeter of the Rectangle is " + rect.GetPerimeter());
                    break;
                case 6:
                    Console.WriteLine("Area of the Rectangle is " + rect.GetArea());
                    break;
                case 7:
                    Environment.Exit(0);
                    break;
            }
            Console.ReadKey();
        }
    }
}
