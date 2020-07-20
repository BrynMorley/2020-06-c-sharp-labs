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

            Camera pentax = new Camera("Pentax");
            Bowgun pistol = new Bowgun("SuperSoaker","WaterPistol",0);
            LaserGun laserGun = new LaserGun("Acme", "LaserGun", 5);
            Hunter nish = new Hunter("Nish", "Mandal", pentax);
            Console.WriteLine(nish.Shoot());
            nish.Shooter = pistol;
            Console.WriteLine(nish.Shoot());
            nish.Shooter = laserGun;
            Console.WriteLine(nish.Shoot());
            nish.Shooter = pistol;
            Console.WriteLine(nish.Shoot());


























           // LaserGun LaserRifle = new LaserGun("Laser Rifle", "Laser Gun", 1);
           // MonsterHunter Bryn = new MonsterHunter("Bryn", "Morley", "Sony",LaserRifle) {Age = 24};
           //// Person Nish = new Person("Nish", "Mandal") { Age = 30 };

           // Monster Rathalos = new Monster("Rathalos",10);
           // Monster Kirin = new Monster("Kirin",25) { IsElderDragon = true };

           // Ranged Shooter = new Ranged("Shooter", "Gun", 1);

           // Console.WriteLine(LaserRifle.Shoot());
           // Console.WriteLine(Shooter.Shoot());

           // Console.WriteLine(Bryn);
           // Console.WriteLine();
           // for (int i = 0; i < 10; i++)
           // {
           //     Console.WriteLine(Bryn.Attack(Rathalos));
           // }
            


           // Console.WriteLine(Bryn.Capture(Rathalos));
           // Console.WriteLine(Bryn.Capture(Kirin));
           // Console.WriteLine();
           // //for (int i = 0; i < 30; i++)
           // //{
           // //    Console.WriteLine(Bryn.Capture(Rathalos));
           // //}

           // Console.WriteLine();
           // Console.WriteLine();


            


        }
    }
}
