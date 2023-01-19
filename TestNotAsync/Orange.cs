using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAsync
{
    internal class Orange
    {
        public Jus Presser(int duration = 1)
        {
            Task.Delay(TimeSpan.FromSeconds(duration)).Wait();
            Console.WriteLine("Le jus est pressé");

            return new();
        }
    }
}
