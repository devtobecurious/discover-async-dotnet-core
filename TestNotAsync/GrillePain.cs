using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAsync
{
    internal class GrillePain
    {
        public Pain[] Griller(Pain[] pains, int duration = 1)
        {
            Task.Delay(TimeSpan.FromSeconds(duration * pains.Length)).Wait();

            foreach (var item in pains)
            {
                item.EstGrille = true;
            }
            Console.WriteLine("Les pains sont grillés");

            return pains;
        }
    }
}
