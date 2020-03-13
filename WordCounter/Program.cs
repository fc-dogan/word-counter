using System;
using WordCounter.Models;

namespace WordCounter
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Word Counter");
      Search();
    }

    public static void Search()
    {
      Console.WriteLine("Please enter a word you would like to search for in a sentence: ");
      string inputtedWord = Console.ReadLine();
      Console.WriteLine("Enter a sentence to search for the word in: ");
      string inputtedSentence = Console.ReadLine();
      Counter newCounter = new Counter(inputtedWord, inputtedSentence);
      newCounter.SplitSentence(inputtedSentence);
      newCounter.CheckWord(inputtedWord);

      Console.WriteLine("-----------------------------"); 
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine($"'{inputtedWord}' is found {newCounter.Count} times in '{inputtedSentence}' sentence.");
      Console.ResetColor();
      Console.WriteLine("-----------------------------"); 
      SearchAgain();
    }

    public static void SearchAgain()
    {
      Console.WriteLine("Would you like to search again? [Y or N]");
      string response = Console.ReadLine().ToUpper();
      if (response == "Y")
      {
        Search();
      }
      else if (response == "N")
      {
        Console.WriteLine("Goodbye.");
      }
      else
      {
        Console.WriteLine("Please enter 'Y' or 'N");
        SearchAgain();
      }
    }

  }
}