using TrioBattleOOP;
Ally Carl = new Ally("Carl");
Human Johnny = new Human("Johnny");
Zombies Clerk = new Zombies("Clerk");
Zombies Owner = new Zombies("Owner");

Console.WriteLine(" Welcome to ZombieLand");
while( Johnny.Health > 0 && Clerk.Health > 0 && Carl.Health > 0  && Owner.Health > 0)
{
  
    if(Johnny.Health >= 0 && Carl.Health >= 0)
    {
        Console.WriteLine($"Keep Killing Zombies");
    }
    else
    {
        Console.WriteLine($"We died");
    }
    
    if(Clerk.Health > 0 && Owner.Health > 0)
    {
    if (Johnny.Health >= 0 && Carl.Health >= 0)

        Console.WriteLine($"-- Player Turn {Carl} -- ");
        Carl.Attack(Owner);
        Console.WriteLine($" Carls Healt is:{Carl.Health}");
        Console.ReadLine();
        Console.WriteLine($"-- Player Turn {Clerk} -- ");
        Clerk.Bite(Johnny);
        Console.ReadLine();
        Console.WriteLine($"-- Player Turn{ Johnny} -- ");
        Johnny.Dodge(Clerk);
        Console.ReadLine();
        Console.WriteLine($"-- Player Turn{ Carl} -- ");
        Carl.HeavyAttack(Clerk);
        Console.ReadLine();
        Console.WriteLine(Clerk.Health);
        Console.WriteLine($"-- Player Turn{ Johnny} -- ");
        Carl.HeavyAttack(Clerk);
        Console.ReadLine();
        Johnny.HeavyAttack(Clerk);
        Console.WriteLine($"-- Player Turn{ Carl} -- ");
        Carl.HeavyAttack(Owner);
        Clerk.Bite(Carl);
        Johnny.HeavyAttack(Clerk);
        Carl.HeavyAttack(Clerk);

        Console.ReadLine();
        Console.WriteLine($"Zombie health Clerk {Clerk.Health}  Zombie Health {Owner}");
    {
    }
        Console.WriteLine($"Zombies are cleared");

    }
    

    else
    {
        Console.WriteLine($"We died");
    }


}
