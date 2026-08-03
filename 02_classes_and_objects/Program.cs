/*

==> In C#, top-level statements must come first, means object 
    initilization comes first, below it comes class declaration.

--> Or everything can be put inside a Main() method.

    class Program
    {
        static void Main()
        {
            Player player1 = new Player();

            Console.WriteLine(player1.name);
            Console.WriteLine(player1.health);

            player1.Attack();
        }
    }

--> Main() function is inside a class, Because C# requires every
    method to belong to a class. A method cannot exist by itself.

*/

Player player1 = new Player();

Console.WriteLine(player1.name);
Console.WriteLine(player1.health);

player1.Attack();

class Player
{
    public string name = "Hero";
    public int health = 100;

    public void Attack()
    {
        Console.WriteLine("Player Attacked!");
    }
}