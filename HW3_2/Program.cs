namespace HW3_2;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first bool value");
        var firstBoolValue = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("Enter second bool value");
        var secondBoolValue = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("p\tq\tp&q\tp|q\tp^q\t!p");
        Console.WriteLine($"{firstBoolValue}\t{secondBoolValue}\t{firstBoolValue && secondBoolValue}\t{firstBoolValue || secondBoolValue}\t{firstBoolValue ^ secondBoolValue}\t{!firstBoolValue}");
    }
}
