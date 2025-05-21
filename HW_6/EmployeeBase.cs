namespace HW_6;

public abstract class EmployeeBase
{   
    private string _name;

    public string Position { get; set; }
    public string Name
    {
        get { return _name; }
        set 
        { 
            if (string.IsNullOrEmpty(value))
            {
                _name = "Unknown";
            }
            else
            {
                _name = char.ToUpper(value[0]) + value.Substring(1).ToLower();
            }
        }
    }

    public EmployeeBase()
    {
        Name = "Unknown";
        Position = "Unknown";
    }

    public EmployeeBase(string name, string position) 
    {
        Name = name;
        Position = position;
    }

    public abstract string GetDetails();
}
