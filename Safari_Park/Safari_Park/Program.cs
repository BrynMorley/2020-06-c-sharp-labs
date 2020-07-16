using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Xml;

namespace Safari_Park
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon BigDoots = new Weapon("Big Dooter", "Hunting Horn", 1);
            MonsterHunter Bryn = new MonsterHunter("Bryn", "Morley", "Sony",BigDoots) {Age = 24};
           // Person Nish = new Person("Nish", "Mandal") { Age = 30 };

            Monster Rathalos = new Monster("Rathalos",10);
            Monster Kirin = new Monster("Kirin",25) { IsElderDragon = true };


            Console.WriteLine(Bryn);
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Bryn.Attack(Rathalos));
            }
            


            Console.WriteLine(Bryn.Capture(Rathalos));
            Console.WriteLine(Bryn.Capture(Kirin));
            Console.WriteLine(
                );
            //for (int i = 0; i < 30; i++)
            //{
            //    Console.WriteLine(Bryn.Capture(Rathalos));
            //}

            Console.WriteLine();
            Console.WriteLine();

           
            //Airplane a = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 };
            //a.Ascend(500);
            //Console.WriteLine(a.Move(3));
            //Console.WriteLine(a);
            //a.Descend(200);
            //Console.WriteLine(a.Move());
            //a.Move();
            //Console.WriteLine(a);
            

            //var safariList = new List<Object>();
            //safariList.Add(Bryn);
            //safariList.Add(Nish);

            //foreach (var item in safariList)
            //{
            //    Console.WriteLine(item);
            //}


        }
    }
}
