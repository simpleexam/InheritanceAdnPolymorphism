using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course1 = new Course("МДК 01.01");
            Course course2 = new Course("МДК 01.02");

            course1.AddStudent("Иванов ИИ");
            course1.AddStudent("Сергеев СС");
            course1.AddStudent("Петров ПП");

            course2.AddStudent("Иванова МИ");
            course2.AddStudent("Смирнов ВВ");

            Console.WriteLine($"количество студентов в курсе {course1.CourseName}: " +
                $"{course1.Students.Count()}\n" +
                $"записанные на курс студенты:");
            int n = 1;
            foreach (var student in course1.Students)
            {
                Console.WriteLine(n + ": " + student);
            }

            Console.WriteLine("-----------------");

            Console.WriteLine($"количество студентов в курсе {course2.CourseName}: " +
               $"{course2.Students.Count()}\n" +
               $"записанные на курс студенты:");
            n = 1;
            foreach (var student in course2.Students)
            {
                Console.WriteLine(n + ": " + student);
            }
        }
    }
}

