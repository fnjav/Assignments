using Config;
using MassTransit;
using System;
using System.Threading.Tasks;

namespace Uppgift4
{
    public class RegisterStudentGradeResult : IConsumer<IStudentRegistrationResult>
    {
        /// <summary>
        /// Recieves the message
        /// </summary>
        /// <param name="context">Message</param>
        /// <returns>Task</returns>
        public Task Consume(ConsumeContext<IStudentRegistrationResult> context)
        {
            IStudentRegistrationResult result = context.Message;
            Console.WriteLine(result.Reply);
            return Task.FromResult(context.Message);
        }
    }
}
