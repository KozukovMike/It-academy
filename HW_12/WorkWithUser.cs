using System.Text.Json;

namespace HW_12;

public static class WorkWithUser
{
    public static List<User> UsersList = new List<User>();

    private static string FilePath = "users.json";

    public static void AddUser(User user)
    {
        UsersList.Add(user);
    }

    public static void ShowUsers()
    {
        Console.WriteLine();
        foreach (User user in UsersList)
        {
            Console.WriteLine($"Name: {user.Name}, Age: {user.Age}, Email: {user.Email}");
        }
        Console.WriteLine();
    }

    public static void CreateFile()
    {
        if (!File.Exists(FilePath))
        {
            using (File.Create(FilePath)) { };
        }
    }

    public static void SaveUsersToFile()
    {
        string json = JsonSerializer.Serialize(UsersList);
        File.WriteAllText(FilePath, json);
        UsersList.Clear();
    }

    public static void LoadUsersToList()
    {
        string json = File.ReadAllText(FilePath);
        try
        {
            UsersList = JsonSerializer.Deserialize<List<User>>(json).Concat(UsersList).ToList();
        }
        catch (System.Text.Json.JsonException e)
        {
        }
    }

    public static void ClearFile()
    {
        File.WriteAllText(FilePath, string.Empty);
    }
}
