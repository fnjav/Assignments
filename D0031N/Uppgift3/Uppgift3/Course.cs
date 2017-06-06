using System.Collections.Generic;

namespace Uppgift3
{
    public class Course
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public List<Models.Student> StudentList { get; set; }

        public Course()
        {
            StudentList = new List<Models.Student>();
        }

        /// <summary>
        /// Adds a new student to the list of students
        /// </summary>
        /// <param name="student">Student to be added</param>
        /// <returns>True</returns>
        public bool AddNewStudent(Models.Student student)
        {
            StudentList.Add(student);
            return true;
        }


    }
}
