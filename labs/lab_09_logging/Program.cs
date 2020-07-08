using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace lab_09_logging
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("Output.log", $"Printing i \n\n"  );
            #region loop with stopwatch
            var stopwatch = new Stopwatch();
            stopwatch.Start();
           
            for (int i =0; i < 10; i++)
            {
                Console.WriteLine(i);
                File.AppendAllText("Output.log", $"The value of i is {i} at {DateTime.Now}\n");
                Thread.Sleep(500);
            }
            stopwatch.Stop();

            Console.WriteLine(stopwatch.Elapsed);
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
            Console.WriteLine(stopwatch.ElapsedTicks);

            stopwatch.Start();
            Thread.Sleep(500);
            stopwatch.Stop();

            Console.WriteLine(stopwatch.Elapsed);
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
            Console.WriteLine(stopwatch.ElapsedTicks);
            #endregion


            //interrogate log file

            //1. simple way
            //output one is in bin
            Console.WriteLine($"\n\n Output as String \n\n");
            string text = File.ReadAllText(@"D:\Github\2020-06-c-sharp-labs\labs\lab_09_logging\bin\Debug\netcoreapp3.1\Output.log");

            Console.WriteLine(text);

            //Output 2 is in the same folder as the sln
            string outputAsString = File.ReadAllText("../../../Output2.log");

            Console.WriteLine(outputAsString);

            //2. each line pushed into array
            Console.WriteLine($"\n\n Output as Array \n\n");

            string[] outputAsArray = File.ReadAllLines("Output.log");

            foreach (string line in outputAsArray)
            {
                Console.WriteLine(line);
            }
        }
    }
}
