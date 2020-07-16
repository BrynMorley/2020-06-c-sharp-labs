using System;
using System.Collections.Generic;
using System.Text;

namespace Safari_Park
{
    public class MonsterHunter : Hunter ,IShootable
    {
        private Weapon _weapon = new Weapon();
        public MonsterHunter(string fName, string lName, IShootable PShooter, string weapon) : base(fName,lName,PShooter)
        {
            _weapon.Name = weapon;
        }
        public MonsterHunter(string fName, string lName, IShootable PShooter, Weapon Equipped) : base(fName, lName, PShooter)
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
            if (monster.Health > 0) 
            { 
                return $"{GetFullName()} hits {monster.Name} with {_weapon.Name} doing {_weapon.Damage} damage.";
            }       
            else
            {
                return $"{GetFullName()} hits {monster.Name} with {_weapon.Name} and kills it!";
            }
        }
        public override string ToString()
        {
            return $"{base.ToString()}  Weapon:{_weapon.Name}"; 
        }
    }
}
