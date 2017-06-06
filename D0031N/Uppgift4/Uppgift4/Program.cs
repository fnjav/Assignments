using Config;
using MassTransit;
using MassTransit.BusConfigurators;
using MassTransit.Log4NetIntegration.Logging;
using MassTransit.RabbitMqTransport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till uppgift 4");
            Console.Title = "Del ett";
            SendMessage();

        }

        /// <summary>
        /// Sends registration message to the other application
        /// </summary>
        private static void SendMessage()
        {
            string address = "rabbitmq://localhost";
            string queue = "uppgift4.domains.queueGrade";
            Uri rootUri = new Uri(address);

            IBusControl busControl = Bus.Factory.CreateUsingRabbitMq(r =>
            {
                r.Host(rootUri, settings =>
                {
                    settings.Username("guest");
                    settings.Password("guest");
                });
            });

            Task<ISendEndpoint> sendEndpointTask = busControl.GetSendEndpoint(new Uri(string.Concat(address, "/", queue)));
            ISendEndpoint sendEndpoint = sendEndpointTask.Result;

            while (true)
            {
                var message = CreateMessage();

                Task sendTask = sendEndpoint.Send<IStudentRegistration>(new
                {
                    Ideal = message[0],
                    CourseCode = message[1],
                    Term = message[2],
                    ExamNumber = message[3],
                    Grade = message[4]
                });
                WaitForMessage();
            }


        }


        /// <summary>
        /// Creates the message, information about student
        /// </summary>
        /// <returns>List of string for student</returns>
        private static List<string> CreateMessage()
        {
            Console.Write("Enter Ideal: ");
            var ideal = Console.ReadLine();
            Console.Write("Enter Course Code: ");
            var courseCode = Console.ReadLine();
            Console.Write("Enter Term: ");
            var term = Console.ReadLine();
            Console.Write("Enter Exam Number: ");
            var examNumber = Console.ReadLine();
            Console.Write("Enter Grade: ");
            var grade = Console.ReadLine();

            return new List<string>
            {
                ideal,
                courseCode,
                term,
                examNumber,
                grade
            };
        }

        /// <summary>
        /// Recieves message
        /// </summary>
        private static void WaitForMessage()
        {
            IBusControl busControl = Bus.Factory.CreateUsingRabbitMq(r =>
            {
                IRabbitMqHost rabbitMqHost = r.Host(new Uri("rabbitmq://localhost"), s =>
                {
                    s.Username("guest");
                    s.Password("guest");
                });

                r.ReceiveEndpoint(rabbitMqHost, "uppgift4.domains.queueResult", conf =>
                {
                    conf.Consumer<RegisterStudentGradeResult>();
                });
            });

            busControl.Start();
            //Console.WriteLine("Press any key to register another student");
            //Console.ReadKey();
            busControl.Stop();
        }
    }

}
