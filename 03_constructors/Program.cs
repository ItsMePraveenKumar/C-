Player player = new Player();
Console.WriteLine(player.name);
Console.WriteLine(player.health + "\n");

// ---------------------------------------------------------

Player p2 = new Player("Knight", 200);
Console.WriteLine(p2.name);
Console.WriteLine(p2.health + "\n");

// ---------------------------------------------------------

class Player
{
    public string name = "Praveen";
    public int health = 100;

    // 1. Default Constructor
    public Player()
    {
        Console.WriteLine("-- Constructor --");
    }

    // 2. Parameterized Constructor
    public Player(string playerName, int playerHealth)
    {
        name = playerName;
        health = playerHealth;
    }

    // 3. Destructors: Runs before the object is garbage collected.
    ~Player()
    {
        Console.WriteLine("-- Destructor --");
    }

    // 4. Dispose: Used to manually release unmanaged resources like files or database connections.
    public void Dispose()
    {
        Console.WriteLine("-- Disposed --");
    }
}

/*

Object Created
       │
       ▼
Constructor
       │
       ▼
Object Used
       │
       ▼
Dispose() (optional)
       │
       ▼
Garbage Collector
       │
       ▼
Finalizer (if present)

--> You don't use constructors or finalizers for game logic.

--> Instead, Unity provides its own lifecycle methods such as:

Awake()
OnEnable()
Start()
Update()
FixedUpdate()
LateUpdate()
OnDisable()
OnDestroy()

--> These are the lifecycle methods you'll use in game development.

*/