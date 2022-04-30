using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapTwoNum
{
    internal class SwapTwoNum
    {
        static void Main(string[] args)
        {
            int val1, val2;
            val1 = 100;
            val2 = 200;

            Console.WriteLine("Value before swap...");
            Console.WriteLine(val1.ToString());
            Console.WriteLine(val2.ToString());

            val1 = val1 + val2;
            val2 = val1 - val2;
            val1 = val1 - val2;

            Console.WriteLine("Values after swap...");
            Console.WriteLine(val1.ToString());
            Console.WriteLine(val2.ToString());
            Console.ReadLine();
        }
    }
}
