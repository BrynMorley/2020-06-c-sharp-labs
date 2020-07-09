using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace lab_13_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x = 1;
            int y = x++;
            Console.WriteLine(x);
            Console.WriteLine(y);

            int a = 1;
            int b = ++a;
            Console.WriteLine(a);
            Console.WriteLine(b);
            */

            /*
            var averageArrary = new int[] { 2, 5, 1, 8 };
            double average = averageArrary.Average();
            Console.WriteLine(average);
            */

            //var a = 5 / 2;
            //var b = 5.0 / 2;
            //var c = 5 / 3;

            /*
            int days = 26 % 7;
            int weeks = 26 / 7;

            Console.WriteLine($"Weeks: {weeks} and Days: {days}");
            */

            /*
            bool isWearingAParachute = true;
            bool jumpoutofPlane = false;

            if (isWearingAParachute && jumpoutofPlane)
            {
                Console.WriteLine("Jump");
            }
            else
            {
                Console.WriteLine("Don't Jump");
            }
            */

            //int x = 3;
            //int y = -2;
            //Console.WriteLine(x=+y);

            int a = 5, b = 3, c = 4;
            c += +a++ + ++b;
        }
    }
}
