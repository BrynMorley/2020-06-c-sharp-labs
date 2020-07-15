using System;
using System.Collections.Generic;
using System.Text;

namespace Safari_Park
{
    public class MonsterHunter : Hunter
    {
        private Weapon _weapon = new Weapon();
        public MonsterHunter(string fName, string lName, string camera,string weapon) : base(fName,lName,camera)
        {
            _weapon.Name = weapon;
        }
        public MonsterHunter(string fName, string lName, string camera, Weapon Equipped) : base(fName, lName, camera)
        {
            _weapon.Name = Equipped.Name;
            _weapon.Type = Equipped.Type;
            _weapon.Damage = Equipped.Damage;
        }

        public string Capture(Monster monster)
        {
            if (!monster.IsElderDragon)
            {
                Random rand = new Random();
                int num = rand.Next(1, 11);

                if (num != 1)
                {
                    return $"{GetFullName()} attempts to capture {monster.Name} ...... and caught it!";
                }
                else
                {
                    return $"{GetFullName()} attempts to capture {monster.Name} ...... but it escaped!";
                }
            }
            else
                return $"{GetFullName()} attempts to capture {monster.Name} but it's an Elder Dragon!";
        }

        public string Attack(Monster monster)
        {
            monster.Health -= _weapon.Damage;
            return $"{GetFullName()} hits {monster.Name} with {_weapon.Name} doing {_weapon.Damage} damage.";
        }
        public override string ToString()
        {
            return $"{base.ToString()}  Weapon:{_weapon.Name}"; 
        }
    }
}
