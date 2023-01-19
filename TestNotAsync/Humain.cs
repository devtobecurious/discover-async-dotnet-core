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
        public PetitDejeuner PreparerPetitDejeuner()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            PetitDejeuner petitDejeuner = new();

            petitDejeuner.Jus = (new Orange()).Presser();
            petitDejeuner.PainsGrilles = (new GrillePain()).Griller(new[] { new Pain(), new Pain() });

            var poele = new Poele();
            poele.ChaufferLaPoele();
            petitDejeuner.OeufGrilles = poele.Cuire(new[] { new Oeuf() });

            this.BeurrerTartines(petitDejeuner.PainsGrilles);

            sw.Stop();

            Console.WriteLine("Temps écoulé {0}", sw.Elapsed);
            return petitDejeuner;
        }

        private void BeurrerTartines(Pain[] pains)
        {
            foreach (var p in pains)
            {
                Task.Delay(TimeSpan.FromSeconds(0.5f)).Wait();
                p.EstBeurre = true;
                Console.WriteLine("La tartine est beurrée");
            }
        }

    }
}
