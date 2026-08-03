/*
01. Auto Property
    get → Read the value.
    set → Change the value.
*/
class Player
{
    public int Health { get; set; }
}

/*
02. Read-Only Property
    Can read from anywhere.
    Can modify only inside the class.
*/
class Player
{
    public int Health { get; private set; } = 100;
}

/*
03. Read-Only Property (get only)
    The value cannot be changed after initialization.
*/
class Player
{
    public int MaxHealth { get; } = 100;
}

/*
04. Full Property
    You can validate or modify the value before storing it.
*/
class Player
{
    private int health;

    public int Health
    {
        get
        {
            return health;
        }

        set
        {
            if (value >= 0)
                health = value;
        }
    }
}
