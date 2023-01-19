using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAsync
{
    internal class Orange
    {
        public async Task<Jus> Presser(int duration = 1)
        {
            await Task.Delay(TimeSpan.FromSeconds(duration));
            Console.WriteLine("Le jus est pressé");

            return new();
        }
    }
}
