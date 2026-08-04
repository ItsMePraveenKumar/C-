/*

<*> Lambda Expression
--> A lambda expression is a short way to write a method.

-------------------------------------------------------------------

01. Action
--> Can take 0 to 16 parameters.
--> Does not return a value (void).
--> Used when you only want to perform an action.

02. Func
--> Can take 0 to 16 parameters.
--> Must return a value.
--> The last type is always the return type.

*/

using System;

class Program
{
    static void Main()
    {   // Action
        Action action = () =>
        {
            Console.WriteLine("Hello");
        };
        action();

        // Func
        Func<int, int, int> add = (a, b) =>
        {
            return a + b;
        };
        Console.WriteLine(add(10, 20));
    }
}