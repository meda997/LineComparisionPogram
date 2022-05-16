using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionProgram
{
    public class Program
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
            double Length1 = length.FindLength();
            double Length2 = length.FindLength();
            {

                if (Length1 < Length2)
                {
                    Console.WriteLine("Line-1 is less than line-2");
                }
                else
                {
                    if (Length2 < Length1)
                    {
                        Console.WriteLine("Line-1 is Greater than line-2");
                    }
                    else
                    {
                        Console.WriteLine("Line-1 is equal to line-2");
                    }
                }


            }

        }
    }
}
    
