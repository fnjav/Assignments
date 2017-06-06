using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Uppgift3.Models
{
    /// <summary>
    /// Not a student, more like a grade for the student.
    /// Ideal, RegistrationCode and grade for each exam number
    /// </summary>
    public class Student
    {
        public int Id { get; set; }
        public string Ideal { get; set; }
        public string RegistrationCode { get; set; }
        public string ExamNumber { get; set; }
        public string Grade { get; set; }
    }


}
