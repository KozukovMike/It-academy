using System.Text.RegularExpressions;

namespace Hw_9_3;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter text");
        var input = Console.ReadLine();
        while (input == "")
        {
            Console.WriteLine("Enter non-empty string");
            input = Console.ReadLine();
        }
        var arrayOfWords = Regex.Replace(input.ToLower(), @"[\p{P}]", "").Split();
        var wordCounter = new Dictionary<string, int>();
        foreach (var word in arrayOfWords)
        {
            if (wordCounter.ContainsKey(word))
            {
                wordCounter[word]++;
            }
            else
            {
                wordCounter.Add(word, 1);
            }
        }
        foreach (var pair in wordCounter)
        {
            Console.WriteLine(pair.Key + ": " + pair.Value);
        }
    }
}
