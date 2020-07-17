using System;
using System.Collections.Generic;
using System.Text;

namespace Safari_Park
{
    abstract public class Weapon
    {
        private string _name;
        private string _type;
        private int _damage;

        public string Name
        {
            get { return _name; } set { _name = value; }
        }
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public Weapon()
        {

        }
        public Weapon(string name, string type, int damage)
        {
            _name = name;
            _type = type;
            _damage = damage;
        }
    }
}
