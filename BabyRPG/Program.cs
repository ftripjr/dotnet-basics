int heroHP = 10, monsterHP = 10;
Random die10 = new Random();
bool heroDead = false, monsterDead = false;

do
{
    // Hero attacks first... 
    int heroAttack = die10.Next(1,11);
    monsterHP -= heroAttack;
    Console.WriteLine($"Monster was hit for {heroAttack}! Monster has {monsterHP} health.");
    monsterDead = monsterHP <= 0 ? true : false;
    
    if (monsterDead) 
        continue;

    // Hero attacks first...
    int monsterAttack = die10.Next(1,11);
    heroHP -= monsterAttack;
    Console.WriteLine($"Hero was hit for {monsterAttack}! Hero has {heroHP} health.");
    heroDead = heroHP <= 0 ? true : false;
} while (!heroDead && !monsterDead);

Console.WriteLine(monsterDead ? $"Hero Wins!" : $"Monster Wins!");