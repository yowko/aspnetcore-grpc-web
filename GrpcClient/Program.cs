// See https://aka.ms/new-console-template for more information

using Greet;
using Grpc.Net.Client;
using Grpc.Net.Client.Web;

var channel = GrpcChannel.ForAddress("http://localhost:5226", new GrpcChannelOptions
{
    HttpHandler = new GrpcWebHandler(new HttpClientHandler())
});


var client = new  Greeter.GreeterClient(channel);


Console.WriteLine($"{ (await client.SayHelloAsync(new HelloRequest(){Name = "gRPCCall"})).Message}");