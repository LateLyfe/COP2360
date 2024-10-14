using System;

class Sentence
{
  string[] words = "The quick brown fox".Split(); //creating an array of words
  
  public string this [int wordNum]      // indexer
  { 
    get { return words [wordNum];  } //getting specified word
    set { words [wordNum] = value; } //setting a value to a word in index
  }

  public string this [Index index] => words [index]; //defining indexer for index type and access to words
  public string[] this [Range range] => words [range]; //defining indexer for range type and access to words

}

class Program
{
    static void Main(string[] args) //Application entry point
    {
        // New instance of the Sentence class
        Sentence s = new Sentence();

        // Displaying the words from the sentance
        for (int i = 0; i < 4; i++) 
        {
            Console.WriteLine(s[i]); //print indexed words into console
        }
    }
}
