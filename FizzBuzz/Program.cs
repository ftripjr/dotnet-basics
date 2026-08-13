/* FizzBuzz - A classic conditional programming question.
    This code iterates through numbers from 1 to 100 (inclusive).
    If the number is divisible by 3, display "Fizz".
    If the number is divisible by 5, display "Buzz".
    If the number is divisible by 3 and 5, display "FizzBuzz".
*/
for (int i = 1; i <= 100; i++)
{
    bool isFizz = (i % 3) == 0;
    bool isBuzz = (i % 5) == 0;

    if(isFizz || isBuzz)
    {
        Console.Write($"{i} - ");
        if (isFizz)
            Console.Write("Fizz");
        if (isBuzz)
            Console.Write("Buzz");

        Console.WriteLine();
    }
    else
        Console.WriteLine($"{i}");
}