int a = 10; // Range: -2,147,483,648 to 2,147,483,647 (4 bytes)
Console.WriteLine(a);

float b = 3.14f; // Precision: ~6–7 decimal digits
double c = 3.14159; // Precision: ~15–16 decimal digits
decimal d = 99.99m; // Precision: ~28–29 decimal digits
Console.WriteLine($"{b} {c} {d}");

char e = 'c';
Console.WriteLine(e);

string f = "Praveen";
Console.WriteLine(f);

bool g = true;
Console.WriteLine(g);

byte h = 10; // Range: 0 to 255 (1 byte, unsigned)
Console.WriteLine(h);

long i = 5000000000L; // Range: -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 (8 bytes)
Console.WriteLine(i);

short j = 300; // Range: -32768 to 32767 (2 bytes, signed)
Console.WriteLine(j);

object k = "Hello"; // Can store any type of value
Console.WriteLine(k);

/*

==> Immutable
--> An immutable object or value cannot be changed after it is created. If you 
    "modify" it, C# actually creates a new object/value instead.

--> All these are Immutable data types.

*/