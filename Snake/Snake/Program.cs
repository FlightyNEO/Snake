using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< Updated upstream
            Console.WriteLine("Hello world");
=======

            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorizontalLine HorizontalLine = new HorizontalLine(5, 10, 8, '-');
            HorizontalLine.Draw();

            VerticalLine VerticalLine = new VerticalLine(15, 1, 10, '|');
            VerticalLine.Draw();

>>>>>>> Stashed changes
            Console.ReadLine();
        }
    }
}
