using System;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Diagnostics.SymbolStore;
using System.IO.Pipes;
using System.Linq.Expressions;
using System.Net;
using System.Net.Cache;
using System.Net.Http.Headers;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;

namespace lab_14_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //var output =  DoThis();
            //  Console.WriteLine(SquareNumber(5,"Hello!"));
            ////OrderPizza(true,true,true);
            //var results = DoThisPartTwo(10, "Leo", out bool isLarge);

            //var myTuple = (fName: "Nish", lName: "Mandal", Age: 18);
            //Console.WriteLine(myTuple);

            //var result = DoThat(10, "Hey Bruno");
            //Console.WriteLine(result);  

            //Console.WriteLine(Add(5, 6));
            //Console.WriteLine(Add(5, 6, 11));
            var answer = 0;
            Console.WriteLine(TripleCalc(2,3,4,out answer));
            Console.WriteLine(answer);
            Console.WriteLine(TripleCalc(2,3,4));
        }

        public static int TripleCalc(int a, int b, int c, out int sum)
        {
            sum = a + b + c;
            return a * b * c;
        }
        public static (int sum,int product) TripleCalc(int a, int b, int c)
        {
            return (a + b + c, a * b * c);
        }
        //public static int Add(int a, int b)
        //{
        //    return a + b;
        //}

        //public static int Add(int a, int b, int c)
        //{
        //    return a + b + c;
        //}

        //public static (int xSquared, bool y_gt_10) DoThat(int x, string y)
        //{
        //    Console.WriteLine(y);
        //    var z = (x > 10);
        //    return (x * x, z);
        //}


        //public static int DoThisPartTwo(int x, string y,out bool z) 
        //{
        //    bool z = (x > 10);
        //    return x * x;
        //}

        //static void OrderPizza(bool pepperoni,bool pineapple, bool banana)
        // {
        //     if (pepperoni == true && pineapple == true && banana == true)
        //     {
        //         Console.WriteLine("Delicious!!");
        //     }
        //     if (pepperoni == true && pineapple == false && banana == true)
        //     {
        //         Console.WriteLine("Where's the giant Mansley?");
        //     }
        //     if (pepperoni == false && pineapple == false && banana == false)
        //     {
        //         Console.WriteLine("where is topping plox");
        //     }
        // }
        //public static void DoThis()
        //{
        //    Console.WriteLine("WE ARE SPARTA!!");
        //}
        //public static string DoThis()
        //{
        //    return "WE ARE SPARTA!!";
        //}

        //public static int SquareNumber(int x, string y)
        //{
        //    Console.WriteLine(y);
        //    return x * x;
        //}
    }
}
