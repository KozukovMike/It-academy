namespace HW_9_1;

internal class Program
{
    static void Main(string[] args)
    {
        var studentList = new List<Student>()
        {
                new Student { Name = "Алексей", Age = 20, AverageRating = 8.5 },
                new Student { Name = "Мария", Age = 18, AverageRating = 6.9 },
                new Student { Name = "Иван", Age = 22, AverageRating = 7.8 },
                new Student { Name = "Ольга", Age = 18, AverageRating = 6.9 }
            };
        studentList.Sort((student1, student2) => student2.AverageRating.CompareTo(student1.AverageRating));
        var youngestStudent = studentList.First();
        foreach (var student in studentList)
        {
            Console.WriteLine(student.Name + " " + student.AverageRating);
            if (youngestStudent.Age > student.Age) // >=
            {
                youngestStudent = student;
            }
        }
        Console.WriteLine("Youngest student");
        Console.WriteLine(youngestStudent.Name + " " + youngestStudent.Age);
    }
}
