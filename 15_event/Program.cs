/*

<*> Event
--> An event lets one object notify other objects when something happens.

*/
using System;

class Player
{
    public event Action OnPlayerDied;

    public void Die() // STEP 3
    {
        Console.WriteLine("Player Died");
        OnPlayerDied?.Invoke(); // STEP 4
    }
}

class Program
{
    static void Main()
    {
        Player player = new Player(); // STEP 1

        // Subscribe to the event
        player.OnPlayerDied += ShowGameOver;

        // Trigger the event
        player.Die(); // STEP 2
    }

    static void ShowGameOver() // STEP 5
    {
        Console.WriteLine("Game Over Screen");
    }
}