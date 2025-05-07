namespace HW4_1;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the length of the array");
        var arrayLength = Convert.ToInt32(Console.ReadLine());
        while (arrayLength < 0)
        {
            Console.WriteLine("Enter а non-negative number, please");
            arrayLength = Convert.ToInt32(Console.ReadLine());
        }
        var array = new object[arrayLength];

        for (var i = 0; i < arrayLength; i++)
        {
            Console.WriteLine("Enter array item");
            array[i] = Console.ReadLine();
        }
        Console.WriteLine();

        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        for (var i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"{array[i]}");
        }
        Console.WriteLine();

        var j = 0;
        while (j < array.Length)
        {
            Console.WriteLine($"{array[j]}");
            j++;
        }
        Console.WriteLine();

        j = 0;
        if (j < array.Length)
        {
            do
            {
                Console.WriteLine($"{array[j]}");
                j++;
            }
            while (j < array.Length);
        }
    }
}
