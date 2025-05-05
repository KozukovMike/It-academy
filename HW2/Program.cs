namespace HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your name?");
            var userName = Console.ReadLine();
            Console.WriteLine("How old are you?");
            var userAge = Convert.ToInt32(Console.ReadLine());
            while (userAge < 0)
            {
                Console.WriteLine("You entered your age incorrectly\nTry one more time, please");
                userAge = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("What is your height?");
            var userHeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Hello, {userName}!\n\tYour age is {userAge}.\n\t\tYour height is {userHeight}");
        }
    }
}
