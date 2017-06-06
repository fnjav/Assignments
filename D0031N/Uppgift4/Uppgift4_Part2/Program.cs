using Config;
using MassTransit;
using MassTransit.RabbitMqTransport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift4_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till uppgift 4, del två");
            Console.Title = "Del två";
            ReceiveMessage();
        }

        /// <summary>
        /// Waits for message
        /// </summary>
        private static void ReceiveMessage()
        {
            IBusControl busControl = Bus.Factory.CreateUsingRabbitMq(r =>
            {
                IRabbitMqHost rabbitMqHost = r.Host(new Uri("rabbitmq://localhost"), s =>
                {
                    s.Username("guest");
                    s.Password("guest");
                });

                r.ReceiveEndpoint(rabbitMqHost, "uppgift4.domains.queueGrade", conf =>
                {
                    conf.Consumer<RegisterStudentGrade>();
                });
            });

            busControl.Start();
            Console.WriteLine("Press any key to exit the application");
            Console.ReadKey();
            busControl.Stop();
        }

        /// <summary>
        /// Sends reply when message is received
        /// </summary>
        /// <param name="result">Result of registration</param>
        public static void SendReply(string result)
        {
            string address = "rabbitmq://localhost";
            string queue = "uppgift4.domains.queueResult";
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

            Task sendTask = sendEndpoint.Send<IStudentRegistrationResult>(new
            {
                Reply = result
            });
        }

    }
}
