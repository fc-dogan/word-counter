using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class Counter 
  {
    public string Sentence {get; set;}
    public string Word {get; set;}
    public int Count {get; set;}
    public static List<string> WordsInSentence {get; set;} = new List<string> {};
    
    public Counter(string word, string sentence)
    {
      Word = word;
      Sentence = sentence;
    }

    public string[] SplitSentence(string sentence)
    {
      string[] sentenceArray = sentence.Split(" ");
      foreach (string currentWord in sentenceArray)
      {
        string newWord = currentWord.ToLower();
        WordsInSentence.Add(newWord);
      }
      return sentenceArray;
    }

    public static List<string> GetAll()
    {
      return WordsInSentence;
    }
  

    public int CheckWord(string word)
    {
     
      foreach(string index in WordsInSentence)
      {
        if(index == word)
        {
          Count =+1;
        }
        else
        {
          Count += 0;
        }
      }
      return Count;
    }
    public static void ClearAll()
    {
      WordsInSentence.Clear();
    }
    // public int CheckWord(string word , string sentence)
    // {
    //   int count = 0;
    //   string[] sentenceArray = SplitSentence(sentence);
    //   foreach(string input in sentenceArray)
    //   {
    //     if (input == word)
    //     {
    //       return count+= 1;
    //     }
    //     else
    //     {
    //       return count += 0;
    //     }
    //   }
    //  return count;
      
    // }


  }
}