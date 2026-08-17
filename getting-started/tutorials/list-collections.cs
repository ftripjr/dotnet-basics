// Intro to Lists - Creating and Modifying a Basic List Example
List<string> names = ["<name>", "Ana", "Felipe"];

// Use a `foreach` loop to print each name in the list `names`
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

Console.WriteLine();
// names[0] = "Sam";

// You can add elements to the end of a list using `.Add()`
names.Add("Billy"); 
names.Add("Mandy");

// You can remove elements from a list using `.Remove()`. If the element does not exist in the list, it will 
names.Remove("Ana");
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

// You can also reference items in a list by index, or it's position in the list. Indices for lists in C# are zero-indexed, meaning the first position is 0.
// A joke can be made about the first item in Lists being second to none, but I'll workshop it before I send it out.
Console.WriteLine($"My name is {names[0]}.");
Console.WriteLine($"I added {names[2]} & {names[3]} to the list.");

// To see how long a list is, use the `.Count` property.
Console.WriteLine($"My names list has {names.Count}.");

// Searching and Sorting
var felipeIndex = names.IndexOf("Felipe");

if (felipeIndex == -1)
{
    Console.WriteLine("There is no Felipe. He was not found in the list.");
}
else
{
    Console.WriteLine($"Found him! Felipe was found in index {felipeIndex}.");    
}

var ghostIndex = names.IndexOf("Not Found");

if (ghostIndex == -1)
{
    Console.WriteLine($"There is no person named \"Not Found\". They were not found in the list.");
}
else
{
    Console.WriteLine($"Found them! The name {names[ghostIndex]} was found in index {ghostIndex}.");    
}

// You can sort list using .Sort() and it will sort the items in the list in ascending order.
names.Sort();
Console.WriteLine("names... sorted");
foreach (var name in names)
{
    Console.WriteLine($"Hi, {name.ToUpper()}");
}

// Lists don't only with with Strings, they can use any type! Let's work with ints.

// Fibonacci Gang
List<int> fibNums = [1,1]; // Starting 2 numbers of the fibonacci sequence.

int prev = fibNums[fibNums.Count - 1]; // Last number in the current list
int prev_2 = fibNums[fibNums.Count - 2]; // Second to last number in the current list

fibNums.Add(prev + prev_2); // the nth term in the fibonacci sequence is the sum of the 2 previous numbers in the sequence. 
// (1 + 1 => 2).
//  so 2 was added to fibNums.

foreach (var number in fibNums)
{
    Console.WriteLine(number);
}
