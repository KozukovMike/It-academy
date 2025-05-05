namespace HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your name?");
            var userName = Console.ReadLine();
            int userAge;
            while (true)
            {
                Console.WriteLine("How old are you?");
                userAge = Convert.ToInt32(Console.ReadLine());
                if (userAge < 0)
                {
                    Console.WriteLine("You entered your age incorrectly\nTry one more time, please");
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("What is your height?");
            var userHeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Hello, {userName}!\n\tYour age is {userAge}.\n\t\tYour height is {userHeight}");
        }
    }
}
