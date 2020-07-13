using System;
using System.Security.Cryptography;

namespace Loops_Brother
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1.Print 1 to 300.");
            Console.WriteLine("2.Print 1 to 300, with messages on 100,200,300.");
            Console.WriteLine("3.Print 1 to 300, with messages on 5, 105, 205.");
            Console.WriteLine("4.Print 50 to 1.");

            int choice = int.Parse(Console.ReadLine());


            switch(choice)
            {
                case 1:
                    for (int i = 1; i <= 300; i++)
                    {
                        Console.WriteLine(i);

                    }
                    break;
                case 2:
                    for (int i = 1; i <= 300; i++)
                    {
                        if (i % 100 == 0)
                        {
                            Console.WriteLine("Hello There!");
                        }
                        else
                        {
                            Console.WriteLine(i);
                        }
                    }
                    break;
                case 3:
                    for (int i = 1; i <= 300; i++)
                    {
                        if ((i - 5) % 100 == 0)
                        {
                            Console.WriteLine("Hello There!");
                        }
                        else
                        {
                            Console.WriteLine(i);
                        }
                    }
                    break;
                case 4:
                    for (int i = 50; i > 0; i--)
                    {
                        Console.WriteLine(i);
                    }
                    break;
            }
                
            

          

           

           
        }
    }
}
