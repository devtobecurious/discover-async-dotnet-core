using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAsync
{
    internal class UrlLoader
    {
        public async Task<int> GetUrlLengthAsync()
        {
            var client = new HttpClient();

            Task<string> getStringTask = client.GetStringAsync("https://docs.microsoft.com/dotnet");

            this.DoIndependantWork();

            string contents = await getStringTask;

            Console.WriteLine("Await ?");

            return contents.Length;
        }

        private void DoIndependantWork()
        {
            Console.WriteLine("Independant");
        }
    }
}
