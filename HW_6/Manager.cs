namespace HW_6;

public class Manager : EmployeeBase
{
    private int _salary;

    public string Education { get; set; }

    public Project AssignedProject { get; set; }

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

    public Manager() : base()
    {
        Education = "Unknown";
        Salary = 0;
    }

    public Manager(int salary, string education, string name, string position) : base(name, position)
    {
        Salary = salary;
        Education = education;
    }

    public Manager(int salary, string education, string name, string position, Project project) : this(salary, education, name, position)
    {
        AssignedProject = project;
    }


    public override string GetDetails()
    {
        return $"{Name} has a salary of {Salary} with {Education} education at position {Position}";
    }

    public void AssignProject(string projectName, DateTime deadline)
    {
        AssignedProject = new Project(projectName, deadline);
    }

    public class Project
    {
        public string projectName;

        public DateTime deadline;

        public Project()
        {

        }

        public Project(string projectName, DateTime deadline)
        {
            this.projectName = projectName;
            this.deadline = deadline;
        }

        public void DisplayProjectInfo()
        {
            Console.WriteLine($"Project name - {this.projectName}, deadline - {this.deadline}");
        }
    }
}
