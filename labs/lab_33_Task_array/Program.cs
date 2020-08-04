using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Threading;
using System.Threading.Tasks;

namespace lab_33_Task_array
{
    class Program
    {
        static Stopwatch s = new Stopwatch();
        static void Main(string[] args)
        {
            s.Start();

            var taskArray = new Task[5];

            taskArray[0] = Task.Run(
               () => { Console.WriteLine($"Task 0 completed"); }
               );
            taskArray[1] = Task.Run(
               () => { Console.WriteLine($"Task 1 completed"); }
               );
            taskArray[2] = Task.Run(
               () => { Console.WriteLine($"Task 2 completed"); }
               );
            taskArray[3] = Task.Run(
               () => {
                 
                   Console.WriteLine($"Task 3 completed"); }
               );
            taskArray[4] = Task.Run(
               () => {
                   
                   Console.WriteLine($"Task 4 completed"); }
               );

            var oneTask = Task.Run(
                () =>
                {
                  
                    Console.WriteLine("Individual task completed");
                }
                );
            var getDataBack = Task<string>.Run(
                () =>
                {
                    return "here is some data returned from background task";
                }
                );

            Task.WaitAny(taskArray);
            Console.WriteLine($"First task in array complete at {s.ElapsedMilliseconds}");
            Task.WaitAll(taskArray);
            Console.WriteLine($"Task array finished at {s.ElapsedMilliseconds}");
            oneTask.Wait();

            Console.WriteLine($"Background data returns at {s.ElapsedMilliseconds} - data is {getDataBack.Result} ");
            Console.WriteLine($"Program ends at {s.ElapsedMilliseconds}");
            Console.ReadLine();
        }

    }
}
