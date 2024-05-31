using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");

      // Define coin values
      int goldValue = 10;
      int silverValue = 5;
      int bronzeValue = 1;

      // Prompt the user for the amount of cents
      Console.Write("Enter the amount of cents you want to convert: ");
      string input = Console.ReadLine();
      int totalCents;
      while (!int.TryParse(input, out totalCents) || totalCents < 0)
      {
        Console.Write("Please enter a valid non-negative integer for cents: ");
        input = Console.ReadLine();
      }

      // Calculate the number of each type of coin
      int goldCoins = totalCents / goldValue;
      int remainder = totalCents % goldValue;

      int silverCoins = remainder / silverValue;
      remainder = remainder % silverValue;

      int bronzeCoins = remainder / bronzeValue;

      // Output the result
      Console.WriteLine($"Minimum number of coins: {goldCoins} gold, {silverCoins} silver, {bronzeCoins} bronze.");
    }
  }
}
