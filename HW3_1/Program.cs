using System;

namespace HW3_1;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How old are you?");
        var userAge = Convert.ToInt32(Console.ReadLine());
        while (userAge < 0)
        {
            Console.WriteLine("You entered your age incorrectly\nTry one more time, please");
            userAge = Convert.ToInt32(Console.ReadLine());
        }
        if (userAge % 2 == 0)
        {
            Console.WriteLine("Your age is even");
        }
        else
        {
            Console.WriteLine("Your age is odd");
        }
        if (userAge >= 0 && userAge <= 2)
        {
            Console.WriteLine("You are a baby");
        }
        else if (userAge >= 3 && userAge <= 12)
        {
            Console.WriteLine("You are a child");
        }
        else if (userAge >= 13 && userAge <= 17)
        {
            Console.WriteLine("You are a teenager");
        }
        else if (userAge >= 18 && userAge <= 59)
        {
            Console.WriteLine("You are an adult");
        }
        else
        {
            Console.WriteLine("You are old");
        }
    }
}
