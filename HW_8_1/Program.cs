using System.Text.RegularExpressions;

namespace HW_8_1;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter string");
        var input = Console.ReadLine();
        while (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Enter something");
            input = Console.ReadLine();
        }
        var cleanInput = Regex.Replace(input.ToLower(), @"[\p{P}\p{Zs}]", "");
        var reversedCleanInput = new string(cleanInput.Reverse().ToArray());
        if (reversedCleanInput == cleanInput)
        {
            Console.WriteLine("Palindrome");
        }
        else
        {
            Console.WriteLine("Not a palindrome");
        }
    }
}
