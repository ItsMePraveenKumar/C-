/*

<*> Abstraction
--> Show only the necessary behavior and hide the implementation details.

01. Abstract Class
--> An abstract class cannot have objects.
    It can have variables.

02. Abstract Methods
--> An abstract have no implementation.
    The child class must implement all abstract methods.

*/

Player p = new Player();
Console.WriteLine(p.health);   // 100

abstract class Character
{
    public int health = 100;   // Variable

    public abstract void Attack();
}

class Player : Character
{
    public override void Attack()
    {
        Console.WriteLine("Player Attacks");
    }
}