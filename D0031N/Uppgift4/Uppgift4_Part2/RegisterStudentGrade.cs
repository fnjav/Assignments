using Config;
using MassTransit;
using System;
using System.Threading.Tasks;

namespace Uppgift4_Part2
{
    public class RegisterStudentGrade : IConsumer<IStudentRegistration>
    {
        public Task Consume(ConsumeContext<IStudentRegistration> context)
        {
            IStudentRegistration reg = context.Message;
            //Console.WriteLine($"Ideal: {reg.Ideal} Course Code: {reg.CourseCode} Term: {reg.Term} Exam Number: {reg.ExamNumber} Grade: {reg.Grade}");

            var regRes = new RegisterResult();
            Program.SendReply(regRes.RegisterStudentResult(reg.Ideal, reg.CourseCode, reg.Term, reg.ExamNumber, reg.Grade));
            return Task.FromResult(context.Message);
        }
    }
}
