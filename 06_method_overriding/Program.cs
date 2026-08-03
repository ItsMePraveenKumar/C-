/*

01. virtual
--> The parent class marks a method as virtual means a child class is 
    allowed to replace this method.

02. override
--> The child class replaces the parent's method.

*/

Player player = new Player();
player.Attack();

class Character
{
    public virtual void Attack()
    {
        Console.WriteLine("Character Attacks");
    }
}

class Player : Character
{
    public override void Attack()
    {
        base.Attack(); // call parent class's method.
        
        Console.WriteLine("Player Attacks");
    }
}