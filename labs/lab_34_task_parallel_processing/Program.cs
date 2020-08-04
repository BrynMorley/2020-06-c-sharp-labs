using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace lab_34_task_parallel_processing
{
    class Program
    {
        delegate void myDelegate();
        
        static void Main(string[] args)
        {
            var s = new Stopwatch();
            Action instance01 = OvernightTask01;
            Action instance02 = OvernightTask02;
            Action instance03 = OvernightTask03;
            Action instance04 = OvernightTask04;
            Action instance05 = OvernightTask05;

            Parallel.Invoke(
                () => {  },
                () => {  },
                () => { },
                () => {  },
                () => {  },
                instance01,
                instance02,
                instance03,
                instance04,
                instance05
                )
                ;
            s.Start();

            var taskArray = new Task[100];
            for (int i = 0; i < taskArray.Length; i++)
            {
                var j = i;
                taskArray[i] = Task.Run(
                    () => {
                        Thread.Sleep(5);
                        Console.WriteLine($"Task {j} is completed in {s.ElapsedMilliseconds}"); }
                    );
            }

            Parallel.For(0,10,
                i =>
                {
                    Thread.Sleep(7);
                     Console.WriteLine($"Parallel For Job {i} - running background processing");
                    
                }
                );

            var stringArray = new string[] { "Hey", "Jude", "Don't", "Make", "It", "Bad" };

            Parallel.ForEach(stringArray,
                (item) => { Console.WriteLine($"Processing string array item {item} with a length of {item.Length}"); }
                );
                   


            Console.WriteLine();
            Console.ReadLine();
        }



        static void OvernightTask01() { Console.WriteLine("Processing overnight task 01"); }
        static void OvernightTask02() { Console.WriteLine("Processing overnight task 02"); }
        static void OvernightTask03() { Console.WriteLine("Processing overnight task 03"); }
        static void OvernightTask04() { Console.WriteLine("Processing overnight task 04"); }
        static void OvernightTask05() { Console.WriteLine("Processing overnight task 05"); }
    }
}
