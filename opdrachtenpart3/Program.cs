// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;
public class Opdrachtenpart2
{

    public static void Main(string[] args)
    {
        List<int> ages = new List<int>();
        Console.WriteLine("geef namen en leeftijden met een komma ertussen(bijvoorbeeld: jan,12) Als je zonder iets in te voeren op enter drukt stopt het programma.");
        while (true)
        {
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                break;
            }

            string[] parts = input.Split(',');
            string name = parts[0].Trim();
            int age = int.Parse(parts[1].Trim());
            ages.Add(age);
        }

        int maxAge = ages[0];
        for (int i = 1; i < ages.Count; i++)
        {
            if (ages[i] > maxAge)
            {
                maxAge = ages[i];
            }
        }

        Console.WriteLine("the leeftijd van het oudste persoon is: " + maxAge);

    }

}