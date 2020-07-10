using System;

namespace lab_18_iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            //for(int i = 100; i >= 0;i--)
            // {
            //     Console.WriteLine(i);
            // }

            //int counter = 10;

            //while(counter<10)
            //{ Console.WriteLine(counter*10);
            //    counter++;
            //}

            //do
            //{
            //    Console.WriteLine(counter);
            //    counter++;
            //}
            //while (counter < 10);


            //int sum = 0;
            //for(int i= 1; i <=100; i++)
            //{ 
            //    sum += i;
            //}
            //Console.WriteLine(sum);
            //string lies = "NISH IS KING";

            //for(int i =0; i <lies.Length; i++)
            //{
            //    Console.WriteLine(lies.ToLower()[i]);
            //}


            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //    if(i == 5)
            //    {
            //        break; 
            //    }
            //}

            //int counter = 0;
            //while(counter <10)
            //{
            //    counter++;
            //    Console.WriteLine(counter);
            //    if (counter < 4) continue;
            //    Console.WriteLine(counter * 4);
            //}    

            ///// DO NOT USE //////
            //Console.WriteLine("Hello");

            //goto a;
            //Console.WriteLine("World");

            //a:
            //Console.WriteLine("and Eng-66");

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i);
                if (i % 15 == 0)
                {
                    break;
                }
            }
        }
    }
}
