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
      var correct = false;
      var input = "";
      var playAgain = true;

      Console.WriteLine();
      Console.WriteLine("Welcome! Press Enter to start a number-guessing game.");
      while (Console.ReadKey().Key != ConsoleKey.Enter) { }

      while (playAgain == true)
      {
        Console.WriteLine();
        Console.WriteLine($"Think of a number between {min} and {max}");

        while (correct == false)
        {
          Console.WriteLine();
          Console.WriteLine($"Is your number {guess}? (y/n)");
          input = Console.ReadLine();
          if (input == "y" || input == "Y")
          {
            Console.WriteLine();
            Console.WriteLine($"Your number is {guess}! It took me {guessCount} guesses.");
            Console.WriteLine();

            correct = true;
          }
          else if (input == "n" || input == "N")
          {
            Console.WriteLine();
            Console.WriteLine($"OK then. Is your number higher or lower than {guess}?");
            input = Console.ReadLine();
            if (input == "higher")
            {
              lower = guess + 1;
              guessCount++;
            }
            else if (input == "lower")
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
        }

        Console.WriteLine("Would you like to play again? (y/n)");
        input = Console.ReadLine();
        if (input == "n" || input == "N")
        {
          Console.WriteLine();
          Console.WriteLine("OK, have a good day!");
          Console.WriteLine();
          playAgain = false;
        }
        else if (input == "y" || input == "Y")
        {
          correct = false;
          lower = min;
          upper = max;
          guess = (upper - lower) / 2;
          guessCount = 1;
        }
      }
    }
  }
}
