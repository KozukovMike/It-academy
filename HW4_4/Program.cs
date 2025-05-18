namespace HW4_4;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("If you want to finish the game type 'yes', otherwise enter watever you want");
            var isEnd = Console.ReadLine().ToLower() == "yes" ? true: false;
            if (isEnd) 
            {
                Console.WriteLine("Thanks for playing");
                break;
            }
            Console.WriteLine("Enter the direction of movement\nW-up\tS-down\tA-left\tD-right");
            var movement = Console.ReadLine().ToLower();
            switch (movement) 
            {
                case "w":
                    Console.WriteLine("Figure moved up");
                    break;
                case "s":
                    Console.WriteLine("Figure moved down");
                    break;
                case "a":
                    Console.WriteLine("Figure moved left");
                    break;
                case "d":
                    Console.WriteLine("Figure moved right");
                    break;
                default:
                    Console.WriteLine("You enter a wrang letter, please try again");
                    break;
            }
        }
    }
}
