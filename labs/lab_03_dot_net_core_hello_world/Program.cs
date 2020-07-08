#define RUNNINGTEST01
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace lab_03_dot_net_core_hello_world
{
    class Program
    {
        static void Main(string[] args)
        {

            #region maincodeblock

            Console.WriteLine("Hello World From A Programmer!");
            int[] myArray = {1,2,3,4,5};
            foreach(var item in myArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            int total = 0;
            for(int i=0; i < 5; i++)
            {
               // Console.WriteLine(i);
                total += i;
            }

            #endregion maincodeblock

#if DEBUG
            Console.WriteLine("this is code only compiled in debug mode");
#endif

#if RUNNINGTEST01
            Console.WriteLine("running test 01");
#endif
            Console.WriteLine("output to console");
            Debug.WriteLine("Output to debug console");
            Trace.WriteLine("Output to trace console");

            Console.ReadLine();

            //TODO: Code this later Bryn
        }
    }
}
