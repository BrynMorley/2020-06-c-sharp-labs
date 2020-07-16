using System;
using System.Collections.Generic;
using System.Text;

namespace Safari_Park
{
    public class Hunter : Person , IShootable
    {
        private IShootable _Shooter;

        public IShootable Shooter 
        {
            get { return _Shooter; }
            set { _Shooter = value; }

        }

        public Hunter(string fName, string lName, IShootable PShooter): base(fName,lName)
        {
            _Shooter = PShooter;
        }

        public Hunter()
        {

        }

        public virtual string Shoot()
        {
            
            return $"{GetFullName()}: {_Shooter.Shoot()}";
        }

        public override string ToString()
        {
            return $"{base.ToString()}  Euipped with: {_Shooter} ";
        }
    }
}
