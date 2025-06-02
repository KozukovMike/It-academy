using System.Globalization;

namespace HW_6;

internal class Program
{
    static void Main(string[] args)
    {
        var manager1 = new Manager();
        var manager2 = new Manager(1000, "BSU", "mike", "junior");
        var worker1 = new Worker();
        var worker2 = new Worker(1000, "glazier", "mike", "1st class");
        EmployeeRegistry.AddEmployee(manager1);
        EmployeeRegistry.AddEmployee(manager2);
        EmployeeRegistry.AddEmployee(worker1);
        EmployeeRegistry.AddEmployee(worker2);
        Console.WriteLine("ALL EMPLOYEES:");
        EmployeeRegistry.ListAllEmployees();
        Console.WriteLine("YOUR EMPLOYEES:");
        EmployeeRegistry.FindEmployee("mike");
        var project = new Manager.Project();
        project.deadline = DateTime.Now;
        project.projectName = "first project";
        manager1.AssignedProject = project;
        manager1.AssignedProject.DisplayProjectInfo();
        var project1 = new Manager.Project();
        project1.deadline = DateTime.Now;
        project1.projectName = "second project";
        manager2.AssignedProject = project1;
        manager2.AssignedProject.DisplayProjectInfo();
        while (true)
        {
            Console.WriteLine("If you want to add \n worker - enter 1 \n manager - enter 2 \n want to stop - enter 3 or nothing");
            var userChoise = Console.ReadLine();
            if (userChoise == "")
            {
                Console.WriteLine("Nothing entered means stop");
                break;
            }
            else if (userChoise == "3")
            {
                break;
            }
            else if (userChoise == "2")
            {   
                Console.WriteLine("If you want to add project to your manager - enter 1, else enter nothing or 2");
                var userProjectChoise = Console.ReadLine();
                if (userProjectChoise == "2" || userProjectChoise == "")
                {
                    EmployeeRegistry.AddEmployee(EmployeeCreator.AddManager());
                }
                else if (userProjectChoise == "1")
                {
                    var inputManager = EmployeeCreator.AddManager();
                    var inputProject = EmployeeCreator.AddProject();
                    inputManager.AssignedProject = inputProject;
                    EmployeeRegistry.AddEmployee(inputManager);
                }
                else
                {
                    Console.WriteLine("You should enter only 1/2/nothing");
                }
            }
            else if (userChoise == "1")
            {
                EmployeeRegistry.AddEmployee(EmployeeCreator.AddWorker());
            }
            else
            {
                Console.WriteLine("You should enter only 1/2/3/nothing");
            }
        }
        Console.WriteLine("What is the employee's name");
        var employeeName = Console.ReadLine();
        Console.WriteLine("ALL EMPLOYEES:");
        EmployeeRegistry.ListAllEmployees();
        Console.WriteLine("YOUR EMPLOYEES:");
        EmployeeRegistry.FindEmployee(employeeName);
    }
}
