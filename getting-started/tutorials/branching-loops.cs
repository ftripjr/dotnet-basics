// ExploreIf();

void ExploreIf()
{
    int a = 5, b = 1;
    if (a + b > 10)
    {
        Console.WriteLine("The answer is greater than 10");
    }
    else
    {
        Console.WriteLine("The answer is not greater than 10");
    }

    int c = 4;
    if ((a + b + c > 10) && (a > b))
    {
        Console.WriteLine("The answer is greater than 10");
        Console.WriteLine("And the first number is greater than the second");
    }
    else
    {
        Console.WriteLine("Either the answer is not greater than 10");
        Console.WriteLine("Or the first number is not greater than the second");
    }

    if ((a + b + c > 10) || (a > b))
    {
        Console.WriteLine("The answer is greater than 10");
        Console.WriteLine("Or the first number is greater than the second");
    }
    else
    {
        Console.WriteLine("The answer is not greater than 10");
        Console.WriteLine("And the first number is not greater than the second");
    }
}

// while loop - counting up
int counter = 0;
while (counter < 10)
{
    Console.WriteLine($"Bonjour! Le counter is at {counter}");
    counter++;
}

// do-while loop - counting down
int down_count = 10;
do
{
    Console.WriteLine($"Heyllo! This counter is at {down_count}");
    down_count--;
} while (down_count >= 0);

// for loop - counting the cookies
for (int cookie_count = 0; cookie_count < 5; cookie_count++)
{
    Console.WriteLine($"I'm hungry! Can I have a cookie!");
    Console.WriteLine($"Thanks! Now I've eaten {cookie_count} cookies. ");
}
