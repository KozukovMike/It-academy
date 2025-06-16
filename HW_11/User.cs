namespace HW_11;

internal class User
{
    public string Name { get; set; }
    public int Age { get; set; }

    public User(string name, int age)
    {
        if (name == "")
        {
            throw new CustomException("Your name must not be empty");
        }
        if (age < 0)
        {
            throw new CustomValueAgeException("Your age must be non-negative");
        }
        Name = name;
        Age = age;
    }
}
