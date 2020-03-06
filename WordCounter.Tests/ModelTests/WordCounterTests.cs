using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class CounterTest
  {
    [TestMethod]
    public void CounterConstructor_CreatesInstanceOfCounter_Counter()
    {
      Counter newCounter = new Counter("test", "sentence test");
      Assert.AreEqual(typeof(Counter), newCounter.GetType());
    }
  }
}