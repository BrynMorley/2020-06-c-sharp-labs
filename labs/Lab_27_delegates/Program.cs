using System;

namespace Lab_27_delegates
{
    class Program
    {
        delegate void MyDelegate01(); 
        static void Main(string[] args)
        {
            //Delegates

            //1. Placeholder for one of more methods
            //2. Can use in anonymous 'lambda' expressions
            //3. Link to events

            var delegateInstance = new MyDelegate01(Method01);
                
            delegateInstance();

        }

        //these are action methods
        static void Method01()
        {
            Console.WriteLine("I am Method01");
        }

        static void Method02()
        {
            Console.WriteLine("I am Method02");
        }
    }
}
