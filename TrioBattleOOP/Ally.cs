using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrioBattleOOP
{
    public class Ally : Human
    {
        public Ally(string name): base(name)
        {
            Name= name;
            Strength = 120;
            Intelligience = 1000;
            Dexterity = 400;
            Health = 500; // Dowble B12 Shots and Coffee lol 

        }
        public override int Attack(Human target)
        {
            int damage = Dexterity * 3;
            target.Dexterity -= damage;
            Console.WriteLine($"{Name} attacked {target.Name} for {damage} damage!");
            return target.Health;
        }

        public int Heal(Human target)
        {
            int cure = Intelligience * 2;
            target.Intelligience += cure;
            Console.WriteLine($"{Name} has healed {target.Name} and restored {cure.ToString()} hp!");
            return target.Health;
        }

    }
}
