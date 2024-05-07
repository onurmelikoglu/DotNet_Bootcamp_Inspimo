using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

var factory = new ConnectionFactory{ HostName = "localhost" };
using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

channel.QueueDeclare(
    queue: "task_queue",
    durable: true,
    exclusive: false,
    autoDelete: false,
    arguments: null
);

channel.BasicQos(prefetchSize: 0, prefetchCount: 1, global: false);

Console.WriteLine(" [x] Waiting for message ");

var consumer = new EventingBasicConsumer(channel);
consumer.Received += async (model, ea) =>
{
    var body = ea.Body.ToArray();
    string message = Encoding.UTF8.GetString(body);
    Console.WriteLine($"[x] Received {message}");
    await Task.Delay(5000);
    channel.BasicAck( deliveryTag: ea.DeliveryTag, multiple: false);
};

channel.BasicConsume(queue:"task_queue", autoAck: false, consumer: consumer);

Console.WriteLine(" Press [enter] to exit ");
Console.ReadLine();
