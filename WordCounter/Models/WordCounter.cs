using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class Counter 
  {
    public string Sentence {get; set;}
    public string Word {get; set;}
    public static int RepeatWord {get; set;}
    
    public Counter(string word,string sentence)
    {
      Word = word;
      Sentence = sentence;
    }

    public string[] SplitSentence(string sentence)
    {
      string[] sentenceArray = sentence.Split(" ");
      return sentenceArray;
    }
    


  }
}