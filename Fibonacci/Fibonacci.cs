using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Fibonacci
    {
        int n = 10;
        int n1 = 0;
        int n2 = 1;
        static void Main(string[] args)
        {
            int n = 10;
            int n1 = 0;
            int n2 = 1;
            Console.WriteLine(n1 + " " + n2 + " ");
            for (int i = 2; i <= n - 1; i++)
            {
                int n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
                //Console.WriteLine(i);
                Console.WriteLine(n3 + " ");
            }
        }
    }
}
