// Strings and String Methods

Console.WriteLine("Hello, World!");
string aFriend = "Breanna";
Console.WriteLine("Hello, " + aFriend);

// Though you can connect strings using + to build strings from variables and constant strings, 
//   you can also use string interpolation by adding a '$' before the quotation marks in an output statement, 
//   and place variables in "{...}" to tell C# to replace the variable with its value in the output string.
aFriend = "Freddie";
Console.WriteLine($"Hello, {aFriend}!");

Console.Write("I love using C#! "); // -> Writes output at the cursor. 
Console.WriteLine("It reminds me of C++."); // -> Writes output at the cursor. Appends a newline after output.
Console.WriteLine("It's such a powerful language!");

Console.WriteLine($"the length of the word \"programmer\" is {"Programmer".Length}"); // -> Writes output at the cursor. Appends a newline after output.
Console.WriteLine($"\"dotnet\" has {"dotnet".Length} letters."); // -> Writes output at the cursor. Appends a newline after output.

// Remove whitespace from strings
Console.WriteLine("\nRemoving Whitespaces from strings");

string greeting = "      Hello World!       ";
Console.WriteLine($"Original Strings: [{greeting}]");

string trimmedGreeting = greeting.TrimStart();      // TrimStart - trims whitespace from the start of the string
Console.WriteLine($"TrimStart: [{trimmedGreeting}]");

trimmedGreeting = greeting.TrimEnd();               // TrimEnd - trims whitespace from the end of the string
Console.WriteLine($"TrimEnd: [{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();                  // Trim - trims whitespace from the start and end of the string
Console.WriteLine($"Trim: [{trimmedGreeting}]");

// Search and Replace
Console.WriteLine("\nSearch and Replace in strings");
string sayYello = "Yello!";
Console.WriteLine(sayYello);
sayYello = sayYello.Replace("Yello", "Salutations");
Console.WriteLine($"Replace 'Yello' with 'Salutations': {sayYello}");
Console.WriteLine($"ToUpper: {sayYello.ToUpper()}");
Console.WriteLine($"ToLower: {sayYello.ToLower()}");

string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine($"\n`songLyrics`: {songLyrics}");
Console.WriteLine($"searching `songLyrics` for 'goodbye': {songLyrics.Contains("goodbye")}");
Console.WriteLine($"searching `songLyrics` for 'greetings': {songLyrics.Contains("greetings")}");

// Challenge

// Two similar methods, StartsWith and EndsWith, also search for substrings in a string. These methods find a substring at the beginning or at the end of the string. Try to modify the previous sample to use StartsWith and EndsWith instead of Contains. Search for "You" or "goodbye" at the beginning of a string. Search for "hello" or "goodbye" at the end of a string.

Console.WriteLine($"\nDoes `songLyrics` begin with 'You': {songLyrics.StartsWith("You")}");
Console.WriteLine($"Does `songLyrics` begin with 'goodbye': {songLyrics.StartsWith("goodbye")}");
Console.WriteLine($"Does `songLyrics` end with 'hello': {songLyrics.EndsWith("hello")}");
Console.WriteLine($"Does `songLyrics` end with 'goodbye': {songLyrics.EndsWith("goodbye")}");

// Summary
Console.WriteLine("In order to work with text, we use the data type, \'strings\'.");
Console.WriteLine("Using string interpolation allows programmers to directly add a variable name between curly braces - { and } - instead of using long lists of variables and addition operators.");
Console.WriteLine("C# allows developers to remove whitespaces from the beginnings and ends of strings.");
Console.WriteLine("C# also has good built-in search methods so developers can find substrings and even replace text in a given string using methods like Contains(), StartsWith(), EndsWith(), Replace, ToUpper(), and ToLower().");
