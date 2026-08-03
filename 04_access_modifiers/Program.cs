/*

01. public:
--> Accessible from anywhere.

02. private:
--> Accessible only inside the same class.

03. protected:
--> Accessible inside the same class and child class.

04. internal:
--> Accessible only inside the same project.

05. protected internal:
--> Accessible if either inside the same project or in a derived (child) class,
    even if it's in another project.

06. private protected:
--> Accessible only if both are true, in the same project and in a derived (child) class.

--> By default in a class variables and methods are private.

*/

class Player
{
    public int health = 100;
}

class Enemy
{
    int protection = 200; // By default a variable/method is private

    public void printHealth()
    {
        Console.WriteLine($"Enemy Protection: {protection}\n");
    }
}

class Game
{
    public static void Main()
    {
        Player p = new Player();
        Console.WriteLine($"Player Health: {p.health}\n");

        Enemy e = new Enemy();
        // Console.WriteLine($"{e.protection}\n"); // Error because "protection" is not accessible.
        e.printHealth();
    }
}