using System;
using Amazon.Lambda.DynamoDBEvents;
using Amazon.Lambda.Serialization.Json;
using Amazon.Lambda.Core;
using System.IO;
using System.Text;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace LambdaDynamoDb
{
    public class DynamoDbEvents
    {
        private static readonly JsonSerializer jsonSerializer = new JsonSerializer();
        
       public void CaptureDynamoDbEvents(DynamoDBEvent dynamoDbEvent)
        {
            Console.WriteLine("Begining to process records...");

            foreach(var record in dynamoDbEvent.Records)
            {
                Console.WriteLine("Event ID: {0}", record.EventID);
                Console.WriteLine("Event Name: {0}", record.EventName);

                string jsonStream = UtilFunction(record.Dynamodb);
                Console.WriteLine("DynamoDb Record: {0}", jsonStream);
            }

            Console.WriteLine("{0} Records processe", dynamoDbEvent.Records.Count);
            
        }
        
        private string UtilFunction(object streamRecord)
        {
            using (var memStream = new MemoryStream())
            {
                jsonSerializer.Serialize(streamRecord, memStream);
                return Encoding.UTF8.GetString(memStream.ToArray());
            }

        }
    }
}
