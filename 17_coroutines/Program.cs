/*

<*> Coroutines
--> A Coroutine lets you pause a method and continue it later without 
    blocking the further code/game.

*/

using System;
using System.Collections;

class Program
{
    static void Main()
    {
        IEnumerator coroutine = MyCoroutine();

        while (coroutine.MoveNext())
        {
            Console.WriteLine(coroutine.Current);
        }
    }

    static IEnumerator MyCoroutine()
    {
        Console.WriteLine("Start");

        yield return "Waiting...";

        Console.WriteLine("End");
    }
}