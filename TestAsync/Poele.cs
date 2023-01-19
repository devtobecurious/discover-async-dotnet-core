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

        public async Task ChaufferLaPoele(int duration = 5)
        {
            await Task.Delay(TimeSpan.FromSeconds(duration));
            Console.WriteLine("La poele est chaude");
        }

        public async Task<Oeuf[]> Cuire(Oeuf[] oeufs, int duration = 10)
        {
            await Task.Delay(TimeSpan.FromSeconds(duration));

            foreach (var item in oeufs)
            {
                item.EstCuit = true;
            }
            Console.WriteLine("Les oeufs sont cuits");

            return oeufs;
        }
    }
}
