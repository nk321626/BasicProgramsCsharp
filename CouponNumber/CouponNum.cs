using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponNumber
{
    internal class CouponNum
    {
        static void Main(string[] args)
        {
            int ranNum = 0;
            int flag = 0;
            Console.WriteLine("enter the coupon num");
            int cnum = int.Parse(Console.ReadLine());
            // Random ran = new random();
            while (ranNum != cnum)
            {
                Random ran = new Random();
                ranNum = ran.Next(0, 100);
                Console.WriteLine(ranNum);
                flag++;
            }
            Console.WriteLine("no of times random no generated is " + flag);

        }
    }
}
