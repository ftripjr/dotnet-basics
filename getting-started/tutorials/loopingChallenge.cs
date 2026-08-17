// Now that you used the if statement and the looping constructs in the C# language, see if you can write C# code to 
//  find the sum of all integers 1 through 20 that are divisible by 3. 

// input: none
// output: list of numbers
// core logic
// create and int called summedFactorsOf3, set to 0
// iterate through all numbers from 1 through 20, inclusive
//     if the the number is divisible by 3
//         add it to summedFactorsOf3

// print summedFactorsOf3. should be 63.

int summedFactorsOf3 = 0;
// iterate through all numbers from 1 through 20, inclusive
for(int currentNum = 0; currentNum <= 20; currentNum++)
{
    // if the the number is divisible by 3
    if (currentNum % 3 == 0)
    {
        // add it to summedFactorsOf3
        summedFactorsOf3 += currentNum;
    }
}

// print summedFactorsOf3. should be 63.
Console.WriteLine($"The sum of the numbers greater than 0 and less than or equal to 20 that are factors of 3 is {summedFactorsOf3}.");
if(summedFactorsOf3 == 63)
    Console.WriteLine("Lo hicimos! We did it!");