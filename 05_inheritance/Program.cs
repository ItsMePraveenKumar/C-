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