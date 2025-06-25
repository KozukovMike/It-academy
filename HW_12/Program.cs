namespace HW_12;

internal class Program
{
    static void Main(string[] args)
    {
        WorkWithUser.CreateFile();
        WorkWithUser.LoadUsersToList();
        if (WorkWithUser.UsersList.Count == 0)
        {
            WorkWithUser.AddUser(new User("mike", 22, "mike@mail"));
            WorkWithUser.AddUser(new User("vova", 25, "vova@mail"));
            WorkWithUser.SaveUsersToFile();
        }
        var flag = true;
        while (flag)
        {
            Console.WriteLine("If you want to stop - write stop\n" +
                "want to add user - write add\n" +
                "want to see all users - write all\n" +
                "want to save list of users - write save\n" +
                "want to load list of users - write load\n" + 
                "want to clear file - write clear\n"
                );
            var input = Console.ReadLine();
            switch (input)
            {
                case "stop":
                    flag = false;
                    break;
                case "add":
                    Console.WriteLine("Enter users name");
                    var name = Console.ReadLine();
                    Console.WriteLine("Enter an email");
                    var email = Console.ReadLine();
                    Console.WriteLine("Enter users age");
                    var age = 0;
                    try
                    {
                        age = int.Parse(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e + "\nYou entered an incorrect number");
                    } 
                    var user = new User(name, age, email);
                    WorkWithUser.AddUser(user);
                    break;
                case "all":
                    WorkWithUser.ShowUsers();
                    break;
                case "save":
                    WorkWithUser.SaveUsersToFile();
                    break;
                case "load":
                    WorkWithUser.LoadUsersToList();
                    break;
                case "clear":
                    WorkWithUser.ClearFile();
                    break;
                default:
                    Console.WriteLine("You entered an incorrect command");
                    break;
            }
        }
    }
}
