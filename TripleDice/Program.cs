// See https://aka.ms/new-console-template for more information
Random die = new();

int roll1 = die.Next(1,7);
int roll2 = die.Next(1,7);
int roll3 = die.Next(1,7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Rolls: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll1 == roll3) || (roll2 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("TRIPLE ROLL! +6 BONUS!!");
        total += 6;
    }
    else
    {
        Console.WriteLine("DOUBLE ROLL! +2 BONUS!!");
        total += 2;
    }
    Console.WriteLine($"Your total plus bonus is {total}");
}

if (total >= 16)
{
    Console.WriteLine("You win a new car!");
} 
else if (total >= 10) 
{
    Console.WriteLine("You win a laptop!");
} 
else if (total == 7) 
{
    Console.WriteLine("You win a trip to Vegas!");
} 
else {
    Console.WriteLine("You get a $10 gift card!");
}
