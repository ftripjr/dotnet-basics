// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

string[] fraudOrderIDs = {"A123", "B456", "C789"};


Console.WriteLine($"Fraud IDs");
Console.WriteLine($"No.\tID");
Console.WriteLine($"1\t{fraudOrderIDs[0]}");
Console.WriteLine($"2\t{fraudOrderIDs[1]}");
Console.WriteLine($"3\t{fraudOrderIDs[2]}\n");
Console.WriteLine($"Count of Fraudulent Order IDs:\t{fraudOrderIDs.Length}\n");

string[] names = {"Adam", "Eve", "Abel"};
int[] inventory = {200,450,700,175,250};
int sum = 0;

foreach (string name in names)
{
    Console.WriteLine(name);
}

foreach (int items in inventory)
{
    sum += items;
}
Console.WriteLine($"There are {sum} items in inventory.");