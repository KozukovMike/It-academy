using System.Globalization;

namespace HW_6;

public static class EmployeeCreator
{
    public static Manager AddManager()
    {
        Console.WriteLine("Enter the manager's name");
        var name = Console.ReadLine();
        Console.WriteLine("Enter the manager's position");
        var position = Console.ReadLine();
        Console.WriteLine("Enter the manager's education");
        var education = Console.ReadLine();
        Console.WriteLine("Enter the manager's salary");
        var inputSalary = Console.ReadLine();
        var salary = 0;
        if (!string.IsNullOrEmpty(inputSalary))
        {
            salary = int.Parse(inputSalary);
        }
        return new Manager(salary, education, name, position);
    }

    public static Worker AddWorker()
    {
        Console.WriteLine("Enter the worker's name");
        var name = Console.ReadLine();
        Console.WriteLine("Enter the worker's position");
        var position = Console.ReadLine();
        Console.WriteLine("Enter the work area");
        var workArea = Console.ReadLine();
        Console.WriteLine("Enter the worker's salary");
        var inputSalary = Console.ReadLine();
        var salary = 0;
        if (!string.IsNullOrEmpty(inputSalary))
        {
            salary = int.Parse(inputSalary);
        }
        return new Worker(salary, workArea, name, position);
    }

    public static Manager.Project AddProject()
    {
        Console.WriteLine("Enter the project's deadline as year-month-day");
        var inputDeadline = Console.ReadLine();
        DateTime deadline = DateTime.ParseExact(inputDeadline, "yyyy-MM-dd", CultureInfo.InvariantCulture);
        Console.WriteLine("Enter the project's name");
        var projectName = Console.ReadLine();
        return new Manager.Project(projectName, deadline);
    }
}
