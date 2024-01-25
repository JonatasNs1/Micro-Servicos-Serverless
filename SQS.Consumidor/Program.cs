using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;
namespace SQS.Consumidor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var client = new AmazonSQSClient(RegionEndpoint.SAEast1);
        }
    }
}
