using Microsoft.AspNetCore.SignalR.Client;
using System.Threading.Tasks;

namespace signalr_websocket_client
{
    public class Program
    {
        static async Task Main()
        {
            var uri = "http://localhost:5000/server";

            await using var connection = new HubConnectionBuilder().WithUrl(uri).Build();
            await connection.StartAsync();

            connection.On<dynamic>("Count", (message) => {
                System.Console.WriteLine(message); 
            });

            System.Console.ReadLine();
        }
    }
}
