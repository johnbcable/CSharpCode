using System.Net.Http;
using System.Threading.Tasks;
using static System.Console;

namespace AsyncConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("http://www.microsoft.com/");

            WriteLine("Microsoft's home page has {0:N0} bytes.",
            response.Content.Headers.ContentLength);
        }
    }
}
