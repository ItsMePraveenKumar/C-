/*

<*> Interface
--> An interface is a contract (or blueprint) that tells a class what
    methods or properties it must have, but not how they work.
    The class provides the implementation.

01. Cannot have variables.
02. A class implements an interface or multiple.

------------------------------------------------------------------------------

Abstract Class	                         Interface

Used when classes share common code      Used when classes share only a 
and data.                                capability/behavior.  


Can have implemented methods, fields,    Cannot have instance fields or
and constructors.	                     constructors; mainly defines a contract.

A class can inherit only one abstract    A class can implement multiple
class.	                                 interfaces.

*/
interface IAnimal
{
    void Sound();   // Method declaration (no body)
}

interface IHeal
{
    void Heal();
}

class Dog : IAnimal, IHeal
{
    public void Sound()
    {
        Console.WriteLine("Dog barks");
    }
}

class Program
{
    static void Main()
    {
        IAnimal animal = new Dog();
        animal.Sound();
    }
}