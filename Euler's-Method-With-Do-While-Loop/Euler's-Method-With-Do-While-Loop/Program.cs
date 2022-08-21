using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_s_Method_With_Do_While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 100000;
            do
            {
                Console.WriteLine("Please Enter the Time : ");

                double x = Double.Parse(Console.ReadLine());

                Console.WriteLine("Please Enter your point");

                double y = Double.Parse(Console.ReadLine());

                double z = 0.2 * y;

                double e = 1 - x;

                double s = e / 100;

                double a = z * s;

                double r = a * x;

                double b = y + r;

                Console.WriteLine("your next point is : {0}", b);

                i--;
            }
            while (i > 0);
            Console.Read();
        }
    }
}
