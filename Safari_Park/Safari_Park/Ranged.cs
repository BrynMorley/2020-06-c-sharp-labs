using System;
using System.Collections.Generic;
using System.Text;

namespace Safari_Park
{
    abstract public class Ranged : Weapon ,IShootable
    {
        public Ranged(string name, string type, int damage) :base(name,type,damage)
        {

        }
      
        
        public virtual string Shoot()
        {
            return $"Shooting a {this.ToString()} - {Name}";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
