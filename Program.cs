sing System;

abstract class Character
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }

    public Character(string name, int health, int attackPower)
    {
        Name = name;
        Health = health;
        AttackPower = attackPower;
    }

    public abstract void Attack(Character target);
}

class Archer : Character
{
    public Archer(string name) : base(name, 80, 15) { }

    public override void Attack(Character target)
    {
        Console.WriteLine($"{Name} ban ten vao {target.Name} gây {AttackPower} sát thương!");
        target.Health -= AttackPower;
    }
}

class Warrior : Character
{
    public Warrior(string name) : base(name, 120, 10) { }

    public override void Attack(Character target)
    {
        Console.WriteLine($"{Name} tan cong {target.Name} gây {AttackPower} sat thương!");
        target.Health -= AttackPower;
    }
}

class Mage : Character
{
    public Mage(string name) : base(name, 70, 20) { }

    public override void Attack(Character target)
    {
        Console.WriteLine($"{Name} dung phep thuat tan cong {target.Name} gây {AttackPower} sat thuong!");
        target.Health -= AttackPower;
    }
}

class Game
{
    static void Main()
    {
        Archer archer = new Archer("Legolas");
        Warrior warrior = new Warrior("Thorin");
        Mage mage = new Mage("Gandalf");

        archer.Attack(warrior);
        warrior.Attack(mage);
        mage.Attack(archer);

        Console.WriteLine($"{warrior.Name} còn {warrior.Health} HP");
        Console.WriteLine($"{mage.Name} còn {mage.Health} HP");
        Console.WriteLine($"{archer.Name} còn {archer.Health} HP");
    }
}
