using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecouverteInjectionDependances
{
    internal class Trotinnette : IMoyenDeDeplacement
    {
        public void SeDeplacer()
        {
            Console.WriteLine("Je me déplace en bougeant un pied et j'ai l'air fun .. :D");
        }
    }
}
