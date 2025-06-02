using System.Globalization;

namespace HW_8_3;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter sting");
        var input  = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Enter a non-empty string");
            input = Console.ReadLine();
        }
        Console.WriteLine("To lower:" + input.ToLower());
        Console.WriteLine("To upper:" + input.ToUpper());
        Console.WriteLine("Capitalize:" + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower()));
    }
}
