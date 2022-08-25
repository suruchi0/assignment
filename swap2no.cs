using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class SwappingTwoNosFunc
    {
        public static void swappingtwonum(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;

        }

        public static void Main()
        {
            int a;
            int b;
            int swapped;
            Console.WriteLine("Enter first number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Before swap: a={a} and b={b}");

            swappingtwonum(ref a, ref b);

            Console.WriteLine($"After Swapping: a={a} and b={b}");

        }
    }
}