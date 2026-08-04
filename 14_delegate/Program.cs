/*

<*> Delegate
--> A delegate is a variable that can store a reference to a method.

*/
MyDelegate action = Jump;
action += Attack;

action(); // Calls both function 1 after another

void Jump()
{
    Console.WriteLine("Jump");
}

void Attack()
{
    Console.WriteLine("Attack");
}

delegate void MyDelegate();