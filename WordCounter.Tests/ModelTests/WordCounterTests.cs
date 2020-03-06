using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class CounterTest
  {
    [TestMethod]
    public void Counter_CreatesInstanceOfCounter_Counter()
    {
      Counter newCounter = new Counter("this is a test sentence");
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
    
  }
}// public void Counter_ReturnsList_List()
    // {
    //   List<string> compare = new List<string> {};
    //   Counter newCounter = new Counter("test", "this is a test sentence");
      
    // }