using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Microsoft.Azure.EventGrid.Models;
using Microsoft.Azure.WebJobs.Extensions.EventGrid;

namespace SBEvents.ProcesseventsFunc
{
    public static class ProcessMessageOnSBEvents001
    {
        [FunctionName("ProcessMessageOnSBEvents001")]
        [return: EventGrid (TopicEndpointUri = "MyEventGridTopicUriSetting", TopicKeySetting = "MyEventGridTopicKeySetting")]
        public static EventGridEvent Run([ServiceBusTrigger("user", "evengrid", Connection = "sbsukute_SERVICEBUS")]string mySbMsg, ILogger log) 
        {
            var id = Guid.NewGuid();
            log.LogInformation($"C# ServiceBus topic trigger function processed message: {mySbMsg}");
            
            return new EventGridEvent(id.ToString(),"Event", mySbMsg, "Event",DateTime.UtcNow,"1.0");
        }
    }
}
