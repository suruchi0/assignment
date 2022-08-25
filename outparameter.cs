using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class MinOfTwoNosFunc
    {
        public static void MinMax(int a, int b, out int MinNum)
        {

            MinNum = Math.Min(a, b);

        }

        public static void Main()
        {
            Console.WriteLine("Enter the numbers to be compared: ");

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int MinNum;

            MinMax(n1, n2, out MinNum);

            Console.WriteLine($"The minimum number after comparing the two numbers is {MinNum}");
        }
    }
}