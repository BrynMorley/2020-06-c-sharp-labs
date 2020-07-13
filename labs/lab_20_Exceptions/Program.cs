using System;
using System.Runtime.CompilerServices;

namespace lab_20_Exceptions
{
    class Program
    {

        private static string[] _theBeatles = new string[] { "John", "Paul", "George", "Ringo" };

        public static void AddBeatle(int pos, string name)
        {
            //try
            //{
            //    _theBeatles[pos] = name;
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine("Cannot add to an array");
            //}
            //finally
            //{
            //    Console.WriteLine("Here comes the sun");
            //}

            if (pos <0 || pos >=  _theBeatles.Length)
            {
                throw new ArgumentException($"The Beatles do not have a position {pos}");
            }
        }

        static void Main(string[] args)
        {
           // AddBeatle(4, "Brian");

            //checked
            //{
            //    int three = 3;
            //    int sum = int.MaxValue + 3;
            //    Console.WriteLine(sum);
            //}



            //int x = 10;
            //int y = 0;

            //try
            //{
            //    int output = x / y;
            //}
            //catch 
            //{
            //    Console.WriteLine("an exception has occured")
            //}
            //finally
            //{
            //    Console.WriteLine("Cannot divide by 0");
            //}
        }
    }

    class Beatles
    {
        public static void AddBeatle(int pos, string name)
        {
            //try
            //{
            //    _theBeatles[pos] = name;
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine("Cannot add to an array");
            //}
            //finally
            //{
            //    Console.WriteLine("Here comes the sun");
            //}

            if (pos < 0 || pos >= _theBeatles.Length)
            {
                throw new ArgumentException($"The Beatles do not have a position {pos}");
            }
        }
    }
}
