using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    internal class ReverseNumber
    {
        static void Main(string[] args)
        {
            int Rev = 0;
            int rem = 0;
            Console.WriteLine("enter the number to reverse");
            int num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                rem = num % 10;
                Rev = Rev * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine("number after reverse is :" + Rev);



        }
    }
}
