namespace HW_12;

public class User
{
    public string Name { get; set; }
    private int _age;
    public string Email { get; set; }

    public int Age
    {
        get { return _age; }
        set 
        { 
            if (value < 0)
            {
                Console.WriteLine("Age should be non-negative");
                _age = 0;
            }
            else
            {
                _age = value;
            }
        }
    }

    public User()
    {
        Name = string.Empty;
        Age = 0;
        Email = string.Empty;
    }

    public User(string name, int age, string email)
    {
        Name = name;
        Age = age;
        Email = email;
    }
}
