using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecouverteInjectionDependances
{
    internal class Humain
    {
        //public Velo Velo { get; set; }

        //public Voiture Voiture { get; set; }
        private IMoyenDeDeplacement moyenDeDeplacementParDefaut;

        public Humain(IMoyenDeDeplacement moyenDeDeplacement)
        {
            this.moyenDeDeplacementParDefaut = moyenDeDeplacement;
        }


        public void EmmenerEnfants(IMoyenDeDeplacement moyenDeDeplacement)
        {
            if (moyenDeDeplacement == null)
            {
                moyenDeDeplacement = this.moyenDeDeplacementParDefaut;
            }

            moyenDeDeplacement.SeDeplacer();

            //Voiture voiture = new ();
            //Velo velo = new ();

            //var ilPleut = true;

            //if (ilPleut)
            //{
            //    Console.WriteLine(voiture);
            //}
            //else
            //{
            //    Console.WriteLine(velo);
            //}

        }
    }
}
