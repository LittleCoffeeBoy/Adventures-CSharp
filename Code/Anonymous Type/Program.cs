using System;
using System.Collections.Generic;
using System.Linq;

// Reference: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/anonymous-types
public class Program
{
    public static void Main(string[] args)
    {
        // "If you do not specify member names in the anonymous type, the compiler gives the anonymous type members the same name as the property being used to initialize them."
        var studentList = new List<Student>
        {
            new Student() { ID = 1, Name = "Douglas", Age = 17 },
            new Student() { ID = 2, Name = "John", Age = 23},
            new Student() { ID = 3, Name = "Lucas", Age = 32}
        };

        var studentAges = from student in studentList
                          where student.Age <= 23
                          select student;

        foreach (Student student in studentAges)
        {
            Console.WriteLine($"{student.Name} {student.Age}");
        }

        Console.Write("Press any key to exit.");
        Console.ReadKey();
    }
}

public class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}