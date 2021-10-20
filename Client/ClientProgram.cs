using System;
using System.Net.Sockets;
using System.Text;
using Utillities;

namespace Client
{

    class ClientProgram : IHandler
    {
        
    }

    static void Main(string[] args)
    {

            var client = new NetworkClient();

            client.Connect("localhost", 5000);

            var message = "hello";
            client.Write(message);

            var response = client.Read();

            Console.WriteLine($"Server response '{response}'");

    }
    
}
