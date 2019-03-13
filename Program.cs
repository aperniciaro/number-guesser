using System;

namespace number_guesser
{
  class Program
  {
    static void StartGame(int min, int max)
    {
      Console.WriteLine();
      Console.WriteLine("Welcome! Press Enter to start a number guessing game.");
      while (Console.ReadKey().Key != ConsoleKey.Enter) { }

      Console.WriteLine();
      Console.WriteLine($"Think of a number between {min} and {max}");
    }
    static void Main(string[] args)
    {
      var min = 0;
      var max = 100;
      var lower = min;
      var upper = max;
      var guess = (upper - lower) / 2;
      var guessCount = 1;
      var correct = false;
      var yesOrNo = "";
      var higherOrLower = "";
      var playAgain = "";

      StartGame(min, max);

      while (correct == false)
      {
        Console.WriteLine();
        Console.WriteLine($"Is your number {guess}? (y/n)");
        yesOrNo = Console.ReadLine();
        if (yesOrNo == "y" || yesOrNo == "Y")
        {
          Console.WriteLine();
          Console.WriteLine($"Your number is {guess}! It took me {guessCount} guesses.");
          Console.WriteLine();

          correct = true;
        }
        else if (yesOrNo == "n" || yesOrNo == "N")
        {
          Console.WriteLine();
          Console.WriteLine($"OK then. Is your number higher or lower than {guess}?");
          higherOrLower = Console.ReadLine();
          if (higherOrLower == "higher")
          {
            lower = guess + 1;
            guessCount++;
          }
          else if (higherOrLower == "lower")
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
      playAgain = Console.ReadLine();
      if (playAgain == "n" || yesOrNo == "N")
      {
        Console.WriteLine("OK, have a good day!");
      }
      else if (playAgain == "y" || yesOrNo == "Y")
      {
        correct = false;
        lower = min;
        upper = max;
        guess = (upper - lower) / 2;
        guessCount = 1;
        StartGame(min, max);
      }
    }
  }
}
