using Grpc.Net.Client;
using gRPCServer;
using System;
using System.Threading.Tasks;

namespace gRPCClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var request = new HelloRequest() { Name = "Shashikant" };
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);

            var reply = await client.SayHelloAsync(request);
            Console.WriteLine(reply.Message);
            Console.ReadLine();


        }
    }
}
