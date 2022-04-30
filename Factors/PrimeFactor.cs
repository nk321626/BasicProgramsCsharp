﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factors
{
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int i, j;
            int count = 0;
            int flag = 0;

            Console.WriteLine("\nPrime Factor of {0} ", num);
            for (i = 2; i < num; i++)
            {
                // check for divisibility
                if(num % i == 0)
                {
                    count = 0;
                    // check for prime factor
                    for(j = 1; j < i; j++)
                    {
                        if (i % j == 0)
                            count++;
                    }
                    if(count == 2)
                    {
                        flag = 1;
                        Console.WriteLine(i + " ");
                    }
                }
            }
            if (flag == 0)
                Console.WriteLine("There is no Prime factor for {0} ", num);
        }
    }
}
