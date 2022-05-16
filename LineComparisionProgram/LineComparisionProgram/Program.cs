using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comparison
{
    internal class Program
    {
        public double FindLength()
        {
            Console.WriteLine("Enter the coordinates of (x1,y1)");
            float x1 = Convert.ToInt32(Console.ReadLine());
            float y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the coordinates of (x2,y2)");
            float x2 = Convert.ToInt32(Console.ReadLine());
            float y2 = Convert.ToInt32(Console.ReadLine());
            double Length = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return Length;

        }

        public static void Main(string[] args)
        {
            Program length = new Program();
            double Length = length.FindLength();
            Console.WriteLine("The length of two points of line :" + Length);
        }
    }
}