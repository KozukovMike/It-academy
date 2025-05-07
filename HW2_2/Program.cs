namespace HW2_2;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number");
        var firstNumber = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter second number");
        var secondNumber = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"sum: {firstNumber + secondNumber}\ndifference: {firstNumber - secondNumber}\n" +
            $"product: {firstNumber * secondNumber}\nquotient: {firstNumber / secondNumber}");
    }
}
