using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.ServiceBus.Messaging;

namespace DBListener
{
    public static class WriteToDB
    {
        [FunctionName("WriteToDB")]
        public static void Run([ServiceBusTrigger("dbqueue", AccessRights.Manage, Connection = "ibmkeSB_RootManageSharedAccessKey_SERVICEBUS")]BrokeredMessage myQueueItem, TraceWriter log)
        //public static void Run(string myQueueItem, TraceWriter log)
        {
            log.Info("Starting");
            System.Threading.Thread.Sleep(3000);
            log.Info($"Po spanku som zmastil: {myQueueItem}");
        }

        [FunctionName("ServiceBusQueueTriggerCSharp")]
        public static void RunMe([ServiceBusTrigger("dbqueue", AccessRights.Manage, Connection = "ibmkeSB_RootManageSharedAccessKey_SERVICEBUS")] string myQueueItem, TraceWriter log)
        {            
            log.Info($"NA BOMBY MASTIM: {myQueueItem}");
        }
    }
}
