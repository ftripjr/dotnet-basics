/*  This code creates a Random object named coin, 
    gets a random number between 1 and 2, and stores
    the flip result in coinFlip. If the flip is 1, 
    coinFlip is heads. Otherwise, it's tails. 
    coinFlip is then printed to the user. */

Random coin = new Random(); // Random object
string coinFlip = coin.Next(1,3) == 1 ? "heads" : "tails"; // rng between 1 and 2. 
Console.WriteLine($"Coin Flip: {coinFlip}"); // show the user the coin flip.
