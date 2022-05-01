using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectNumber
{
    internal class PerfectNumber
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter the Number to check");
            int num = int.Parse(Console.ReadLine());
            int m = num / 2;
            for (int i = 1; i <= m; i++)
            {
                int rem = num % i;
                if (rem == 0)
                {
                    Console.WriteLine(i);
                    sum = sum + i;
                }
                //else
                //break;

            }
            if (sum == num)
            {
                Console.WriteLine("Number is Perfect Number");
            }
            else
                Console.WriteLine("Number is Not Perfect NumberS");
        }
    }
}
