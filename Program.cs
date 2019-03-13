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
      var response = "";

      Console.WriteLine($"Think of a number between {min} and {max}");
      while (response != "equal")
      {
        Console.WriteLine($"Is your number higher, lower, or equal to {guess}?");
        response = Console.ReadLine();
        if (response == "higher")
        {
          lower = guess + 1;
        }
        else if (response == "lower")
        {
          upper = guess - 1;
        }
        guess = (upper + lower) / 2;
      }
      Console.WriteLine($"Your number is {guess}!");
    }
  }
}
