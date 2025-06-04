using System.Text;

namespace HW_8_2;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter string");
        var input = Console.ReadLine();
        var result = new StringBuilder();
        foreach (char item in input)
        {
            if (item != ' ')
            {
                result.Append(item);
            }
        }
        Console.WriteLine(result.ToString());
    }
}
