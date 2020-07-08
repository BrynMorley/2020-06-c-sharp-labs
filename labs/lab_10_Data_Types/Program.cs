using System;
using System.ComponentModel;

namespace lab_10_Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            //int highestValue = int.MaxValue;
            /*
            checked
            {
                int a = Int32.MaxValue;
                int b = a + 1;
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
            */

            /*
            float sum = 0;

            for(int i = 0; i < 1000; i++)
            {
                sum += 1 / 3.0f;
            }

            Console.WriteLine("1/3 added 1000 times: " + sum);

            Console.WriteLine("1/3 multiplied by 1000 " + 1 / 3.0f * 1000);
            */

            //string nish = "nish";

            //char firstLetter = 'b';

            //int firstLetterInt = firstLetter;

            //Console.WriteLine(firstLetterInt);

            //float x = 3.14f;
            //double y = x;
            //Console.WriteLine(y);

            //double x = 3.14f;
            //float y = (float)x;
            //Console.WriteLine(y);

            //int i = 100;
            //double d = i;
            //Console.WriteLine(d);

            /*
            bool likeApples = true;
            Console.WriteLine(likeApples);
            double likeApplesDouble = Convert.ToInt32(likeApples);
            Console.WriteLine(likeApplesDouble);
            */

            //double pi = 3.141592;
            //pi = Math.Round(pi, 3);
            //Console.WriteLine(pi);

            //int num = -5;
            //ulong longNum = (ulong)num;
            //Console.WriteLine(longNum);

            char fourChar = '4';

            int fourInt = fourChar - '0';
            Console.WriteLine(fourInt);

            int fourIntParsed = int.Parse(fourChar.ToString());
            Console.WriteLine(fourIntParsed);

            Console.Write(Char.GetNumericValue('4'));
        }
    }
}
