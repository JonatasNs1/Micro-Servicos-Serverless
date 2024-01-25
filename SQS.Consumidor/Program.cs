using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;
namespace SQS.Consumidor
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var client = new AmazonSQSClient(RegionEndpoint.SAEast1);
            var request = new ReceiveMessageRequest
            {
                QueueUrl = "https://sqs.sa-east-1.amazonaws.com/284213124642/Teste"
            };
           var response = await client.ReceiveMessageAsync(request);

            foreach (var mensagem in response.Messages)
            {
                Console.WriteLine(mensagem.Body);
                client.DeleteMessageAsync("https://sqs.sa-east-1.amazonaws.com/284213124642/Teste", mensagem.ReceiptHandle)
            }
        }
    }
}
