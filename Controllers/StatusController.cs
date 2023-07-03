using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections;
using System.Text;

namespace BackgroundServicesDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StatusController : ControllerBase
    {
        private readonly Models.Configuration _configuration;
        public static Queue dataCollection;
        public StatusController(IOptions<Models.Configuration> myConfig) {
            _configuration = myConfig.Value;
            dataCollection = new Queue();
            ConsumeMessages(_configuration);
        }

        private void ConsumeMessages(Models.Configuration config)
        {
            var factory = new ConnectionFactory
            {
                HostName = config.Hostname,
                UserName = config.Username,
                Password = config.Password,
                AutomaticRecoveryEnabled = config.AutomaticRecoveryEnabled
            };
            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();
            string queue = channel.QueueDeclare().QueueName;
            channel.QueueBind(queue: queue,
             exchange: config.Exchange,
             routingKey: config.RoutingKey);
            var consumer = new EventingBasicConsumer(channel);

            consumer.Received += (ch, ea) =>
            {
                var body = ea.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);
                dataCollection.Enqueue(message);
                Console.WriteLine(message);
            };
            channel.BasicConsume(queue, autoAck: true, consumer);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
