using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimeterProject
{
    class Program
    {
        private static double height;

        static void Main(string[] args)
        {

                Console.WriteLine("Please enter length and width of a room to find the area and area of the space");

            Console.WriteLine("length:");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("width:");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("P = {0}", 2 * (width + length));
            Console.WriteLine("A = {0}", width * length);
            


        }
    }
}
