/*

<*> Types of inheritance:

01. Single Inheritance
    Ex: class Character { }
        class Player : Character { }

02. Multilevel Inheritance
    Ex: class Character { }
        class Enemy : Character { }
        class Boss : Enemy { }

03. Hierarchical Inheritance
    Ex: class Character { }
        class Player : Character { }
        class Enemy : Character { }
        class NPC : Character { }

*/

Player player = new Player();

player.Move();
player.Attack();

class Character
{
    public void Move()
    {
        Console.WriteLine("Moving");
    }
}

class Player : Character // Player class inherited Character class.
{
    public void Attack()
    {
        Console.WriteLine("Attacking");
    }
}