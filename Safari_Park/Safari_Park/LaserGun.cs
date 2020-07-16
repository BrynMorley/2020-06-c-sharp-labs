using System;
using System.Collections.Generic;
using System.Text;

namespace Safari_Park
{
    public class LaserGun : Ranged
    {


        public LaserGun(string name, string type, int damage) : base(name, type, damage)
        {

        }

        public override string Shoot()
        {
            return $"Zing!! {base.Shoot()}";
        }
    }
}
