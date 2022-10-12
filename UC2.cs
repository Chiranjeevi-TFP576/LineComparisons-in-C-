using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisons
{
    internal class UC2
    {
        public static void TwoLinesAreEqual()
        {
            Console.WriteLine("Enter the values of X1,X2,X3,X4");
            int X1 = Convert.ToInt32(Console.ReadLine());
            int X2 = Convert.ToInt32(Console.ReadLine());
            int Y1 = Convert.ToInt32(Console.ReadLine());
            int Y2 = Convert.ToInt32(Console.ReadLine());
            int LengthofLine1 = (int)Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
            Console.WriteLine("Enter the values Of X3,X4,Y3,Y4");
            int X3 = Convert.ToInt32(Console.ReadLine());
            int X4 = Convert.ToInt32(Console.ReadLine());
            int Y3 = Convert.ToInt32(Console.ReadLine());
            int Y4 = Convert.ToInt32(Console.ReadLine());
            int LengthOfLine2 = (int)Math.Sqrt(Math.Pow(X4 - X3, 2) + Math.Pow(Y4 - Y3, 2));
            if (LengthofLine1.Equals(LengthOfLine2))
            {
                Console.WriteLine("\n Two Lines are Equal");
            }
            else
            {
                Console.WriteLine("\n Two lines are Not Equal");
            }
        }
    }
}
