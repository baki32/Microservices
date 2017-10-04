using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ServiceBus.Messaging;

namespace QueuePusher
{
    class Program
    {
        static void Main(string[] args)
        {

            var connectionString = "Endpoint=sb://ibmkesb.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=TuNNt+6pxsSuwHHv4QjETDl5KLp1MAApEotRDTACPW8=";
            var queueName = "dbqueue";

            var client = QueueClient.CreateFromConnectionString(connectionString, queueName);
            var i = 1;
            while (true)
            {
                var message = new BrokeredMessage($"This is a test message! {i++}");

                Console.WriteLine(String.Format("Message id: {0}", message.MessageId));

                client.Send(message);                

                System.Threading.Thread.Sleep(new Random(DateTime.Now.Millisecond).Next(300, 500));
            }

        }
    }
}
