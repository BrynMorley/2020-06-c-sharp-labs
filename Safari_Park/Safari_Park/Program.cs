using System;
using System.Net.Http.Headers;
using System.Xml;

namespace Safari_Park
{
    class Program
    {
        static void Main(string[] args)
        {
            Hunter Bryn = new Hunter("Bryn", "Morley", "Doot Master 3000") {Age = 24};
            Console.WriteLine(Bryn.Age);
            Console.WriteLine(Bryn.Shoot());

            Hunter jimmy = new Hunter();
            Console.WriteLine();
            Console.WriteLine(jimmy.Shoot());
        }
    }
}
