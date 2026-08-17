// Fibonacci Gang
List<int> fibNums = [1,1]; // Starting 2 numbers of the fibonacci sequence.

while (fibNums.Count < 20)
{    
    int prev = fibNums[fibNums.Count - 1]; // Last number in the current list
    int prev_2 = fibNums[fibNums.Count - 2]; // Second to last number in the current list

    fibNums.Add(prev + prev_2); // the nth term in the fibonacci sequence is the sum of the 2 previous numbers in the sequence. 
}

foreach (var number in fibNums)
{
    Console.WriteLine(number);
}

Console.WriteLine($"The 20th Fibonacci number is {fibNums[19]}");
if (fibNums[19] == 6765)
{
    Console.WriteLine("Excellent!");
}