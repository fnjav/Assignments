using System.Collections.Generic;

namespace Uppgift4_Part2
{
    public class Course
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public List<string> StudentList { get; set; }

        public Course()
        {
            StudentList = new List<string>();
        }

        /// <summary>
        /// Adds new student to the list
        /// </summary>
        /// <param name="student"></param>
        public void AddNewStudent(string student)
        {
            StudentList.Add(student);
        }
    }
}
