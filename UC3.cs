using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisons
{
    internal class UC3
    {
        public static void ComparedLinesAreEqual()
        {
            Console.WriteLine("Enter the values of X1");
            int X1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the values of X2");
            int X2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the values of Y1");
            int Y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the values of Y2");
            int Y2 = Convert.ToInt32(Console.ReadLine());
            int Length1 = (int)Math.Sqrt(Math.Pow(X2-X1,2) + Math.Pow(Y2-Y1,2));
            Console.WriteLine("Enter the values Of X3");
            int X3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the values of X4");
            int X4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the values of Y3");
            int Y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the values of Y4");
            int Y4 = Convert.ToInt32(Console.ReadLine());
            int Length2 = (int)Math.Sqrt(Math.Pow(X4 - X3, 2) + Math.Pow(Y4 - Y3, 2));
            if (Length1.Equals(Length2))
            {
                Console.WriteLine("\n Lines are Equal");  
            }
            else if (Length1.CompareTo(Length2)>0)
            {
                Console.WriteLine("\n Line1 is greater");
            }
            else 
            {
                Console.WriteLine("\n Line2 is greater");
            }
        }
    }
}
