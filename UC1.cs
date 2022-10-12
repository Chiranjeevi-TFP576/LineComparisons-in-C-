using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisons
{
    internal class UC1
    {
        public static void LengthOfLines()
        {
            int X1 = Convert.ToInt32(Console.ReadLine());
            int X2 = Convert.ToInt32(Console.ReadLine());
            int Y1 = Convert.ToInt32(Console.ReadLine());
            int Y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" \n\n  Length of the Line is " + Length(X1, X2, Y1, Y2));
            Console.ReadLine();
        }
        private static int Length(int X1, int Y1, int X2, int Y2)
        {
            return (int)Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
        }
    }
}

