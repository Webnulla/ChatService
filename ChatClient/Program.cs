using MessageServiceReference;

namespace ChatClient
{
    public class Program
    {
        static void Main(string[] args)
        {
            MessageServiceClient messageServiceClient =
                new MessageServiceClient("http://localhost:5131", new HttpClient());
            var clientId = messageServiceClient.ConnectAsync("Test").Result;

            MessageClient message = new MessageClient(clientId);

            while (true)
            {
                message.SendMessageAsync(1002, "Hello, World");
                Console.ReadKey();
            }
        }
    }
}