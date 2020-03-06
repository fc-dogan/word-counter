namespace WordCounter.Models
{
  public class Counter 
  {
    public string Sentence {get;}
    public string Word {get; }
    public Counter(string word,string sentence)
    {
      Word = word;
      Sentence = sentence;
    }
    

  }
}