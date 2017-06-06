using System;
using System.Collections.Generic;
using System.Linq;

namespace Uppgift4_Part2
{
    public class RegisterResult
    {
        /// <summary>
        /// "Registers student to database"
        /// </summary>
        /// <param name="ideal">Ideal of student</param>
        /// <param name="course">Course code</param>
        /// <param name="term">Term</param>
        /// <param name="examNumber">Exam number</param>
        /// <param name="grade">Grade</param>
        /// <returns>Resultatet sparat i LADOK or invalid</returns>
        public string RegisterStudentResult(string ideal, string course, string term, string examNumber, string grade)
        {
            switch (CheckStudentOnCourse(GetApplicationCode(course, term), ideal))
            {
                case "valid":
                    return "Resultatet sparat i LADOK";
                case "invalid":
                    return "Invalid";
                default:
                    return "Invalid";
            }
        }

        /// <summary>
        /// Returns application code
        /// </summary>
        /// <param name="course">Course  code</param>
        /// <param name="term">Term</param>
        /// <returns></returns>
        private string GetApplicationCode(string course, string term)
        {
            var _courses = new Dictionary<string, string>()
            {
                { "D0031N", "LTU-1" },
                { "D0023E", "LTU-2" },
                { "D0005N", "LTU-3" },
                { "D0006N", "LTU-4" },
                { "I0015N", "LTU-5" }
            };
            try
            {
                return _courses[course] + $":{term}";
            }
            catch (Exception)
            {
                return "invalid";
            }
        }

        /// <summary>
        /// Checks if student is registered to course
        /// </summary>
        /// <param name="code">Application code</param>
        /// <param name="ideal">Ideal of student</param>
        /// <returns>valid or invalid</returns>
        private string CheckStudentOnCourse(string code, string ideal)
        {
            var _courseList = new List<Course>();

            // Initialize students
            var students = new List<string>()
            {
                "stud-1",
                "stud-2",
                "stud-3",
                "stud-4",
                "stud-5"
            };

            // Initialize courses
            for (int i = 1; i <= 5; i++) // 5st fake kurser
            {
                var course = new Course() { Code = "LTU-" + i + ":H17" };
                foreach (var student in students)
                {
                    course.AddNewStudent(student);
                }
                _courseList.Add(course);
            }

            _courseList.ElementAt(3).AddNewStudent("stud-6"); // stud-6 läser bara LTU-4:H17.

            // Check
            try
            {
                if (_courseList.FirstOrDefault(c => c.Code.Equals(code))
                .StudentList.FirstOrDefault(s => s.Equals(ideal)) != null) //Kraschar om code är fel, try catch fulfix
                    return "valid";
                return "invalid";
            }
            catch (Exception)
            {
                return "invalid";
            }
        }
    }
}
