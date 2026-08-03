/*

<*> Polymorshism:
--> The same method behaves differently.

*/

Player p = new Player();
p.move();
p.move(1);
p.move(4);
p.move(2);
p.move(3);

class Player
{
    public void move()
    {
        Console.WriteLine("Move in 1 direction...");
    }

    public void move(int dir)
    {
        if(dir == 1) Console.WriteLine("Move forward...");
        if(dir == 2) Console.WriteLine("Move left...");
        if(dir == 3) Console.WriteLine("Move right...");
        if(dir == 4) Console.WriteLine("Move backward...");
    }
}