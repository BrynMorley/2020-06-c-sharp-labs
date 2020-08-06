using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace lab_32_Tasks
{
    class Program
    {
        
        
        static Stopwatch s = new Stopwatch();
        static void Main(string[] args)
        {
                
      
            var thread = new Thread(

                () => { Console.WriteLine($"This is a thread {s.ElapsedTicks}"); }
                );

            thread.Start();

            var task01 = new Task(

               () =>
               {
                   Console.WriteLine($"This is a task {s.ElapsedTicks}");
               }
                );

           

            var task02 = new Task(
                () => { Console.WriteLine($"Create and run task  {s.ElapsedTicks}"); }
                );

            
            var task03 = new Task(
             () => { Console.WriteLine($"Create and run task from delegate  {s.ElapsedTicks}"); }
             );

            
            s.Start();

            thread.Start();
            task01.Start();
            task02.Start();
            
           

            Console.WriteLine($"Program has ended at {s.ElapsedMilliseconds}");
            Console.ReadLine();
            
        }
    }
}
