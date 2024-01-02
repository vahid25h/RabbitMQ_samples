using RabbitMQ.Client;
using System.Text;


ConnectionFactory factory = new ConnectionFactory();
factory.Uri = new Uri("amqp://guest:guest@localhost:5672");
factory.ClientProvidedName = "Rabbit Sender App";

IConnection cnn = factory.CreateConnection();

IModel channel = cnn.CreateModel();

string exchangeName = "DemoExchange";
string routingKey = "demo-routing-key";
string queueName = "DemoQueue";

channel.ExchangeDeclare(exchangeName, ExchangeType.Direct);
channel.QueueDeclare(queueName,false,false,false);
channel.QueueBind(queueName,exchangeName,routingKey,null);


byte[] messageBodyBytes = Encoding.UTF8.GetBytes("Hello YouTube");
channel.BasicPublish(exchangeName,routingKey,null,messageBodyBytes);

channel.Close();

cnn.Close();