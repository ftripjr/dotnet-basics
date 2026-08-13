// Declaring and using variable s in C#
// Comments are done using "//"

// Working with strings!
string stringVariable = "Sample Text";
Console.WriteLine(stringVariable);
stringVariable = "Strings are mutable in C#";
Console.WriteLine(stringVariable);

// Literals 
// A literal value is a constant value that never changes. Character literals 
// char - Character literals. 
Console.WriteLine('b');

// int - Integer literals. 
Console.WriteLine(123);
Console.WriteLine(67);
Console.WriteLine(25);

// Floating point literals
Console.WriteLine("Float Type    Precision        Literal Suffix");
Console.WriteLine("-----------------------------------------------");
Console.WriteLine("float         ~6-9 digits            F");
Console.WriteLine("double        ~15-17 digits          n/a");
Console.WriteLine("decimal        28-29 digits          m");

float floatOn = 2.25F;
double doubleIt = 3.141592;
decimal decNumber = 12.39816m;

Console.WriteLine($"\nfloat:  {floatOn}");
Console.WriteLine($"double: {doubleIt}");
Console.WriteLine($"decimal:  {decNumber}");

// Boolean literals
Console.WriteLine($"Does \"123\" equal 123?: {"123".Equals(123)}");

