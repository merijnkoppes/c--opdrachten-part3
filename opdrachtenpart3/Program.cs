// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;
public class Opdrachtenpart2
{

    public static void Main(string[] args)
    { 
                while (true)
        {
            Console.WriteLine("Geef een zin:");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                break;
            }
            string[] parts = input.Split(' ');
    Console.WriteLine(parts[parts.Length - 1]);
        }
    }

}