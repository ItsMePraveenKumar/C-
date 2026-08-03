/*

<*> Encapsulation
--> Encapsulatie similar functionalities together.
    Encapsulation means hiding data and controlling how it is accessed.

*/

Player player = new Player();
player.Health = 80;
Console.WriteLine(player.Health);

class Player
{
    public int Health { get; set; } = 100;
}

/*

public int Health { get; set; } = 100;

----------------------------------------

private int _health = 100;
public int Health
{
    get
    {
        return _health;
    }

    set
    {
        _health = value;
    }
}

*/