namespace HW4_3;

internal class Program
{
    static void Main(string[] args)
    {
        var i = -20;
        do
        {
            Console.WriteLine(i);
            i -= 20;
        }while (i >= -100);
    }
}
