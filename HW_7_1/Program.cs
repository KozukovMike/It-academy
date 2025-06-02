namespace HW_7_1;

internal class Program
{
    static void Main(string[] args)
    {
        int arrayLength = 6;
        var array = new int[arrayLength];
        var i = 0;
        while (i < arrayLength)
        {
            Console.WriteLine("Enter an integer");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                array[i] = number;
                i++;
            }
            else
            {
                Console.WriteLine("Your number is not an integer");
            }
        }
        Array.Sort(array);
        Array.Reverse(array);
        Console.WriteLine();
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
    }
}
