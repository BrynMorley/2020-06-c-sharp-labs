using System;
using System.Runtime.InteropServices.ComTypes;

namespace lab_30_basic_event
{
    class Program
    {

        delegate void MyDelegate();
        static event MyDelegate MyEvent;

        delegate string MyDelegate2(string first, string last);
        static event MyDelegate2 MyEvent2;

        static void Main(string[] args)
        {
            MyEvent += Method01;
            MyEvent += Method02;
            MyEvent += Method03;

            MyEvent();

            MyEvent2 += MyName;
            MyEvent2 += MyNameBackwards;
           

            Console.WriteLine(MyEvent2("Bryn","Morley"));
        }

        static void Method01()
        {
            Console.WriteLine("Running Method01");
        }
        static void Method02()
        {
            Console.WriteLine("Running Method02");
        }
        static void Method03()
        {
            Console.WriteLine("Running Method03");
        }

        static string MyName(string first, string last)
        {
            return $"My name is {first} {last}.";       
        }
        static string MyNameBackwards(string first, string last)
        {
            return $"My name is {last} {first}.";
        }
    }
}
