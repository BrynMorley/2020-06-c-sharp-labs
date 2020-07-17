using System;
using System.Collections.Generic;
using System.Text;

namespace Safari_Park
{
    public class Hunter : Person , IShootable
    {
       

        public IShootable Shooter 
        {
            get;set;
        }

        public Hunter(string fName, string lName, IShootable PShooter): base(fName,lName)
        {
            Shooter = PShooter;
        }

        public Hunter()
        {

        }

        public virtual string Shoot()
        {
            
            return $"{GetFullName()}: {Shooter.Shoot()}";
        }

        public override string ToString()
        {
            return $"{base.ToString()}  Euipped with: {Shooter} ";
        }
    }
}
