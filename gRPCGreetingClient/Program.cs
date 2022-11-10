using System.Threading.Tasks;
using Grpc.Net.Client;
using gRPCGreetingClient;

// The port number must match the port of the gRPC server.
using var channel = GrpcChannel.ForAddress("https://localhost:7051");
var client = new Greeter.GreeterClient(channel);
var reply = await client.SayHelloAsync(
                  new HelloRequest { Name = "GreeterClient" });
Console.WriteLine("Greeting: " + reply.Message);
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
var reply2 = await client.CustomFuncAsync(
new CustomRequest { Name = "Custom Request said hello !!!" });
Console.WriteLine("Greeting: " + reply2.Message);
Console.WriteLine("Press any key to exit...");
Console.ReadKey();