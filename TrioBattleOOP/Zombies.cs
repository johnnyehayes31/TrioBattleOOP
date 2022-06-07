using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrioBattleOOP
{
    public class Zombies: Human
    {
        public Zombies(string name) : base(name)
        {
            Name = name;
            Dexterity = 2000;
            Intelligience = 5;
            Health = 100;
        }
        public override int Attack(Human target)
        {
            Random random = new Random();
            int CriticalChoose =random.Next(0, 50);
            int damage = 0;
            if(CriticalChoose<= 10)
            {
                damage = 10 + (Intelligience * 5);
            }
            else
            {
                damage = Dexterity * 5;
            }
            target.Health -= damage;
            Console.WriteLine($"{Name} attacked {target.Name} for {damage} damage!");
            return target.Health;
        }

        public int Bite(Human target)
        {
            target.Health -= 100;
            Health += 1;
            Console.WriteLine($"{Name} has stole 5 hp from {target.Name}");
            return target.Health;
        }


    }
}
