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
            
            Task preparerOeufs = this.PreparerOeufs(petitDejeuner);
            Task preparerJus = this.PrepareJus(petitDejeuner);
            Task preparerTartines = this.PreparerTartines(petitDejeuner);

            await Task.WhenAll(preparerJus, preparerOeufs, preparerTartines);

            sw.Stop();

            Console.WriteLine("Temps écoulé {0}", sw.Elapsed);
            return petitDejeuner;
        }

        private async Task PreparerOeufs(PetitDejeuner dej)
        {
            var poele = new Poele();

            await poele.ChaufferLaPoele();
            dej.OeufGrilles = await poele.Cuire(new[] { new Oeuf() });
        }

        private async Task PrepareJus(PetitDejeuner dej)
        {
            Task<Jus> preparerJus = (new Orange()).Presser(10);
            dej.Jus = await preparerJus;
        }

        private async Task PreparerTartines(PetitDejeuner dej)
        {
            Task<Pain[]> preparerPains = (new GrillePain()).Griller(new[] { new Pain(), new Pain() });
            dej.PainsGrilles = await preparerPains;
            Task preparerTartines = this.BeurrerTartines(dej.PainsGrilles);
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
