using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAsync
{
    internal class Humain
    {
        public async Task<PetitDejeuner> PreparerPetitDejeuner()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            PetitDejeuner petitDejeuner = new();

            petitDejeuner.Jus = await (new Orange()).Presser();
            petitDejeuner.PainsGrilles = await (new GrillePain()).Griller(new[] { new Pain(), new Pain() });

            var poele = new Poele();
            await poele.ChaufferLaPoele();
            petitDejeuner.OeufGrilles = await poele.Cuire(new[] { new Oeuf() });

            await this.BeurrerTartines(petitDejeuner.PainsGrilles);

            sw.Stop();

            Console.WriteLine("Temps écoulé {0}", sw.Elapsed);
            return petitDejeuner;
        }

        private async Task BeurrerTartines(Pain[] pains, float duration = 0.5f)
        {
            foreach (var p in pains)
            {
                await Task.Delay(TimeSpan.FromSeconds(duration));
                p.EstBeurre = true;
                Console.WriteLine("La tartine est beurrée");
            }
        }

    }
}
