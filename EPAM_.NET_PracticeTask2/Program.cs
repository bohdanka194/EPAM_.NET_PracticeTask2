using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EPAM_.NET_PracticeTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating rectangle1...");
            Rectangle rectangle1 = new Rectangle(1, 5, 4, 3);
            Console.WriteLine("rectangle1:\n" + rectangle1.ToString());
            Thread.Sleep(3000);

            Console.WriteLine("\nCreating rectangle2...");
            Rectangle rectangle2 = new Rectangle(0, 100, 10, 4);
            Console.WriteLine("rectangle2:\n" + rectangle2.ToString());
            Thread.Sleep(3000);

            Console.WriteLine("\nCreating rectIntersect = intersection of rectangle1 and rectangle2...");
            Rectangle rectIntersect = rectangle1.IntersectionWithRectangle(rectangle2);
            Console.WriteLine("rectIntersect: \n" + rectIntersect.ToString());
            Thread.Sleep(3000);

            Rectangle HugeRect = Rectangle.FindRectangleThatContains2Rectangles(rectangle1, rectangle2);
            Console.WriteLine("\nrectangle that contains rectangle1 and rectangle2 : \n" + HugeRect.ToString());
            Thread.Sleep(3000);

            Console.WriteLine("\nMove rectangle1 to -4(line x) and 0(line y)");
            rectangle1.MoveRectangle(-4, 0);
            Console.WriteLine("rectangle1:\n" + rectangle1.ToString());
            Thread.Sleep(3000);

            Rectangle HugeRect2 = Rectangle.FindRectangleThatContains2Rectangles(rectangle1, rectangle2);
            Console.WriteLine("\nrectangle that contains rectangle1 and rectangle2 : \n" + HugeRect2.ToString());
            Thread.Sleep(3000);

            Console.WriteLine("\nResizing rectangle1 by coefficient = 3...");           
            rectangle1.ReSizeRectangle(3);
            Console.WriteLine("rectangle1:\n" + rectangle1.ToString());
            Thread.Sleep(1500);

            Console.WriteLine("\nSuccessfully completed the program!");
            Console.Read();
        }
    }
}
