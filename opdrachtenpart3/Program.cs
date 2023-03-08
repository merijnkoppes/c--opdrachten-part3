// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
using System.Security.Cryptography.X509Certificates;
public class Opdrachtenpart2
{

    public static void Main(string[] args)
    {
        // create the word list for storing strings
        List<string> wordList = new List<string>();

        // add two values to the word list
        wordList.Add("First");
        wordList.Add("Second");
        wordList.Add("Third");
        wordList.Add("Fourth");
        wordList.Add("Fifth");

        // retrieve the value from position 0 of the word list, and print it
        Console.WriteLine("volledige lijst:");
        wordList.ForEach(Console.WriteLine);

        //laatse waarde verwijderen, en daarna printen
        wordList.RemoveAt(wordList.Count - 1);

        Console.WriteLine("\r\nLijst zonded de laatste waarde:");
        wordList.ForEach(Console.WriteLine);
    }

}