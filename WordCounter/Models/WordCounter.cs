namespace WordCounter.Models
{
  public class Counter 
  {
    public string Sentence {get; set;}
    public string Word {get; }
    public Counter(string word,string sentence)
    {
      Word = word;
      Sentence = sentence;
    }
    

  }
}