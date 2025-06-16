namespace HW_11;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your name");
        var name = Console.ReadLine();
        Console.WriteLine("Enter your age");
        try
        {
            var age = int.Parse(Console.ReadLine());
            try
            {
                var user = new User(name, age);
            }
            catch (CustomException e)
            {
                Console.WriteLine(e);
            }
            catch (CustomValueAgeException e)
            {
                Console.WriteLine(e);
            }
        }
        catch (FormatException e)
        {
            Console.Write(e.ToString());
        }
        
    }
}
