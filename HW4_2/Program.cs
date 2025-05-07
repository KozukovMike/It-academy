namespace HW4_2;

internal class Program
{
    static void Main(string[] args)
    {
        for (var i = -95; i <= 95; i += 5)
        {
            if (i <= -10 || i >= 10)
            {
                Console.Write(i + " ");
            } 
        }
    }
}
