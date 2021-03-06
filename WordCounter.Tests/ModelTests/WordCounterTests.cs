using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class CounterTest : IDisposable
  {
    public void Dispose()
    {
      Counter newCounter = new Counter("test");
      newCounter.ClearAll();
    }

    [TestMethod]
    public void Counter_CreatesInstanceOfCounter_Counter()
    {
      Counter newCounter = new Counter("test", "this is a test sentence");
      Assert.AreEqual(typeof(Counter), newCounter.GetType());
    }
    [TestMethod]
    public void GetSentence_ReturnSentence_String()
    {
      string sentence = "this is a test sentence";
      Counter newCounter = new Counter(sentence);
      string result = newCounter.Sentence;
      Assert.AreEqual(sentence, result);
    }
    [TestMethod]
    public void GetWord_ReturnWord_String()
    {
      string word ="test";
      string sentence = "this is a test sentence";
      Counter newCounter = new Counter(word, sentence);
      string result = newCounter.Word;
      Assert.AreEqual(word, result);
    }

    [TestMethod]
    public void SetSentence_SetSentence_String()
    {
      string sentence = "this is a test sentence";
      Counter newCounter = new Counter(sentence);
      string updatedSentence = "new sentence";
      newCounter.Sentence = updatedSentence;
      string result = newCounter.Sentence;
      Assert.AreEqual(updatedSentence, result);
    }
    [TestMethod]
    public void SetWord_SetWord_String()
    {
      string word ="test";
      string sentence = "this is a test sentence";
      Counter newCounter = new Counter(word, sentence);
      string updatedWord = "new";
      newCounter.Word =updatedWord;
      string result = newCounter.Word;
      Assert.AreEqual(updatedWord, result);
    }
    
    [TestMethod]
    public void SplitSentence_ConvertStringToStringArray_StringArray()
    {
      string sentence = "I have a white cat";
      Counter newCounter = new Counter(sentence);
      string input = newCounter.Sentence;
      string[] splitSent = sentence.Split(" ");
      string[] result = newCounter.SplitSentence(input);
      CollectionAssert.AreEqual(result, splitSent);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_List()
    {
      List<string> newList = new List<string>{};
      Counter newCounter = new Counter("test");
      List<string> result = newCounter.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetAll_ReturnWords_List()
    {
      string sentence = "white cat";
      Counter newCounter = new Counter(sentence);
      newCounter.SplitSentence(sentence);
      List<string> newList = new List<string>{"white", "cat"};
      List<string> result = newCounter.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void CheckWord_IsInputtedWordAppearsInTheSentence_Integer()
    {
      string word = "cat";
      string sentence = "White Cat, my cat";
      Counter newCounter = new Counter(word, sentence);
      newCounter.SplitSentence(sentence);
      newCounter.CheckWord(word);
      int result = newCounter.Count;
      Assert.AreEqual(result, 2);
    }





    // [TestMethod]
    // public void CheckWord_InputtedWordAppearsInTheSentence_Integer()
    // {
    //   string word = "cat";
    //   string sentence = "I have a white cat";
    //   Counter newCounter = new Counter(word, sentence);
    //   int result = newCounter.CheckWord(word, sentence);
      
    //   Assert.AreEqual(result, 1);
    // }

    
    
  }
}
