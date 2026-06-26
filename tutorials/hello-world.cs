Console.WriteLine("Hello, World!");
string aFriend = "Breanna";
Console.WriteLine("Hello, " + aFriend);

// Though you can connect strings using + to build strings from variables and constant strings, 
//   you can also add a '$' before the quotation marks in an output statement, 
//   and place variables in "{}" to tell C# to replace the variable with its value in the output string.
aFriend = "Freddie";
Console.WriteLine($"Hello, {aFriend}!");

// Comments are done using "//"

// 
Console.Write("I love using C#! "); 
// -> Writes output at the cursor. 
Console.WriteLine("It's such a powerful language!"); // -> Writes output at the cursor. Appends a newline after output.
Console.WriteLine("It reminds me of C++."); // -> Writes output at the cursor. Appends a newline after output.

// Literals 
// A literal value is a constant value that never changes. Character literals 
// char - Character literals. 
Console.WriteLine('b');

// int - Integer literals. 
Console.WriteLine(123);



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


// Summary