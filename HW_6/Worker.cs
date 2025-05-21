namespace HW_6;

public class Worker : EmployeeBase
{
    private int _salary;

    public string WorkArea { get; set; }

    public int Salary
    {
        get { return _salary; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Enter a non-negative salary");
                _salary = 0;
            }
            else
            {
                _salary = value;
            }
        }
    }

    public Worker() : base()
    {
        Salary = 0;
        WorkArea = "Unknown";
    }

    public Worker(int salary, string workArea, string name, string position) : base(name, position)
    {
        Salary = salary;
        WorkArea = workArea;
    }

    public override string GetDetails()
    {
        return $"{Name} has a salary of {Salary} working as a {WorkArea} at position {Position}";
    }
}
