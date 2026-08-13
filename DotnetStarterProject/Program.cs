// See https://aka.ms/new-console-template for more information
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;
string submssg;

// Your code goes here

if (daysUntilExpiration == 0)
{
    submssg = "Your subscription has expired.";
}
else if (daysUntilExpiration == 1)
{
    discountPercentage = 20;
    submssg = $"Your subscription expires within a day!\nRenew now and save {discountPercentage}%!";
}
else if (daysUntilExpiration <= 5)
{
    discountPercentage = 10;
    submssg = $"Your subscription expires within {daysUntilExpiration} days!\nRenew now and save {discountPercentage}%!";
}
else
{
    submssg = "Your subscription will expire soon. Renew now!";
}

Console.WriteLine(submssg);