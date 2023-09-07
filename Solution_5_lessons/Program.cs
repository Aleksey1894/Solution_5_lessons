using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_5_lessons
{
    internal class Program
    {
        static int Max(int x, int y)
        {
            if (x > y)
                return x;
            else
                return y;
        }
        //Overload by 3 values
        static int Max(int x, int y, int j)
        {
            int max = Max(x, y);
            if (max > j)
                return max;
            else
                return j;
        }

        //overload by 4 values
        static int Max(int x, int y, int j, int k)
        {
            int max = Max(x, y, j);
            if (max > k)
                return max;
            else
                return k;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int a2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Maximum of two numbers is {Max(a1, a2)}");

            Console.Write("Enter third number: ");
            int a3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Maximum of third numbers is {Max(a1, a2, a3)}");

            Console.Write("Enter fourth number: ");
            int a4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Maximum of fourth numbers is {Max(a1, a2, a3, a4)}");
            Console.ReadLine();
        }
    }
}
