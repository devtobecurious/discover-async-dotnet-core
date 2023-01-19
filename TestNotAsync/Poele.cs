using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAsync
{
    internal class Poele
    {
        public bool EstChaude { get; set; } = false;

        public void ChaufferLaPoele(int duration = 5)
        {
            Task.Delay(TimeSpan.FromSeconds(duration)).Wait();
            Console.WriteLine("La poele est chaude");
        }

        public Oeuf[] Cuire(Oeuf[] oeufs, int duration = 10)
        {
            Task.Delay(TimeSpan.FromSeconds(duration)).Wait();

            foreach (var item in oeufs)
            {
                item.EstCuit = true;
            }
            Console.WriteLine("Les oeufs sont cuits");

            return oeufs;
        }
    }
}
