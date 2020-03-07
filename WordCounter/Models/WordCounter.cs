using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class Counter 
  {
    public string Sentence {get; set;}
    public string Word {get; set;}
    public int Count {get; set;} = 0;
    public static List<string> WordsInSentence {get; set;} = new List<string> {};
    
    public Counter(string sentence)
    {
      Sentence = sentence;
    }

    public Counter(string word, string sentence)
      : this(sentence)    
    {
      Word = word;
    }

    public string[] SplitSentence(string sentence)
    {
      char[] toSplit = {' ',',', '.', '!', '?', ';', ':', '\'', '\"'};
      string[] sentenceArray = sentence.Split(toSplit);
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
          Count += 1;
        }
      }
      return Count;
    }
    public static void ClearAll()
    {
      WordsInSentence.Clear();
    }


  }
}