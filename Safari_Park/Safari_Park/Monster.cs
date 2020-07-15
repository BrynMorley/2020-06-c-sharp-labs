using System;
using System.Collections.Generic;
using System.Text;

namespace Safari_Park
{
    public class Monster
    {
        protected string _name;
        private bool _isElderDragon;
        private int _health;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }

        public bool IsElderDragon
        {
            get { return _isElderDragon;}
            set { _isElderDragon = value; }
        }

        public Monster (string name)
        { 
            _name = name;
        }

    }
}
