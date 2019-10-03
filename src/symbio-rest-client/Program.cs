using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace symbio_rest_client
{
    class Program
    {
        static void Main(string[] args)
        {
            Task
                .Run(async () => await CallSymbio())
                .Wait();
        }

        static async Task CallSymbio()
        {
            var uri = "https://localhost/SYMBIO/1803/REST/_api/rest/facets";

            var request = System.Net.WebRequest.CreateHttp(uri) as HttpWebRequest;
            request.Method = "POST";
            request.Headers["symbio-auth-token"] = "9bxgy988g6snz350m25n72yk01";

            using (var response = await request.GetResponseAsync())
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }
    }
}
