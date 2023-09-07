using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min
{
    internal class Program
    {
        static int Min(int x, int y)
        {
            if (x > y)
                return y;
            else
                return x;
        }
        //Overload by 3 values
        static int Min(int x, int y, int j)
        {
            int min = Min(x, y);
            if (min > j)
                return j;
            else
                return min;
        }

        //overload by 4 values
        static int Min(int x, int y, int j, int k)
        {
            int min = Min(x, y, j);
            if (min > k)
                return k;
            else
                return min;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int a2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Minimum of two numbers is {Min(a1, a2)}");

            Console.Write("Enter third number: ");
            int a3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Minimum of third numbers is {Min(a1, a2, a3)}");

            Console.Write("Enter fourth number: ");
            int a4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Minimum of fourth numbers is {Min(a1, a2, a3, a4)}");
            Console.ReadLine();
        }
    }
}
