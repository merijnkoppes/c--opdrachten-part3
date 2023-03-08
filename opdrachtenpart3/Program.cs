// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;
public class Opdrachtenpart2
{

    public static void Main(string[] args)
    {
        int[] sterrenArray = { 2,6, 3, 8, 5 };
        PrintSterrenArray(sterrenArray);
    }
    public static void PrintSterrenArray(int[] array)
    {
        foreach (int numStars in array)
        {
            for (int i = 0; i < numStars; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}