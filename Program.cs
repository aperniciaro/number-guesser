using System;

namespace number_guesser
{
  class Program
  {
    static void Main(string[] args)
    {
      var min = 0;
      var max = 100;
      var lower = min;
      var upper = max;
      var guess = (upper - lower) / 2;
      var guessCount = 1;
      var response = "";

      Console.WriteLine($"Think of a number between {min} and {max}");
      while (response != "equal")
      {
        Console.WriteLine($"Is your number higher, lower, or equal to {guess}?");
        response = Console.ReadLine();
        if (response == "higher")
        {
          lower = guess + 1;
          guessCount++;
        }
        else if (response == "lower")
        {
          upper = guess;
          guessCount++;
        }
        guess = (upper + lower) / 2;
        if (guess == 0)
        {
          guess = 1;
        }
      }
      Console.WriteLine($"Your number is {guess}! It took me {guessCount} guesses.");
    }
  }
}
