using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Course
    {
        private string courseName;
        private List<string> students = new();

        public string CourseName { get => courseName; }
        public List<string> Students { get => students; }

        public Course(string courseName)
        {
            this.courseName = courseName;
        }

        public void AddStudent(string student)
        {
            if (student.Count() < 60)
                students.Add(student);
            else
                throw new ArgumentException(
                    "превышено количество студентов на курсе");
        }

        public void RemoveStudent(string student)
        {
            //TODO
        }
    }
}
