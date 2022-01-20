using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecouverteInjectionDependances
{
    internal class Velo : IMoyenDeDeplacement
    {
        public void SeDeplacer()
        {
            Console.WriteLine("Je pédale vers l'école");
        }
    }
}
