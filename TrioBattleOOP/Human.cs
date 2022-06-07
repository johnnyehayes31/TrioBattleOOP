using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrioBattleOOP
{
    public class Human
    {

        public string Name;
        public int Strength;
        public int Health;
        public int Intelligience;
        public int Dexterity;

        public Human(string name)
        {
            Name = name;
            Strength = 110; // B12 shot
            Health = 500;
            Intelligience = 1000;
            Dexterity = 400;
        }
        public Human(string name, int strength, int health, int intelligience)
        {
            Name=name;
            Strength = strength;
            Health = health;
            Intelligience = intelligience;
            Dexterity = 400;

        }
        public virtual int Attack(Human target)
        {
            int damage = Strength * 3;
            target.Health -= damage;
            Console.WriteLine($"{Name } attacked { target.Name} for {damage}");
            return target.Health;
        }
        public virtual int Dodge(Human target)
        {
            int dodge = Intelligience * 3;
            target.Health += 5;
            Console.WriteLine($" {Name} dodged { target.Name} a bite attack and gained Intelligeince {dodge} ");
            return target.Health;
        }

        public virtual int HeavyAttack(Human target)
        {
            Random random = new Random();
            int killingBlow = random.Next(0, 5);
            int damage = Strength * 5;
            target.Health -= damage;
            Console.WriteLine($"{Name } attacked { target.Name} for {damage}");
            return target.Health;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Intelligience: {Intelligience}");
            Console.WriteLine($"Dextreity: {Dexterity}");
            Console.WriteLine($"Health: {Health}");
            Console.ReadLine();
        }
    }
}
