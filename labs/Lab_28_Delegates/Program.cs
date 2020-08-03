using System;

namespace Lab_28_Delegates
{
    class Program
    {
        delegate void MyDelegate01();

        delegate string Delegate_2(int x, bool y);
        static void Main(string[] args)
        {
            MyDelegate01 myDelegateInstance = Method01;

            Action myotherdelegateinstance = Method02;

            myDelegateInstance();

            Delegate_2 delegate_2instance = Method03;

            Console.WriteLine( delegate_2instance(6, true));
        }
        static void Method01()
        {
            Console.WriteLine("I am Method01");
        }
        static void Method02()
        {
            Console.WriteLine("I am Method02");
        }

        static string Method03(int x, bool y)
        {
            return $"{x} is {y}";
        }
    }
}

    

