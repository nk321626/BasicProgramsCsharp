using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEven
{
    internal class OddEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number to check");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
                Console.WriteLine("Number is Odd");

        }
    }
}
