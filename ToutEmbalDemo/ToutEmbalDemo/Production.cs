using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToutEmbalDemo
{
    public class Production
    {
        public readonly TypeDeCaisse caisse;
        public readonly int nombreDeCaisseAProduire;
        /// <summary>
        /// temps de production des caisses en millisecondes
        /// </summary>
        public readonly int tempsDeProductionParCaisse;
        public  double DefautParHeure { get; private set; }// accesseur
        public  double DefautGlobal { get; private set; }
        public  Boolean Demarre { get; private set; }
        public  int CompteurProduction { get; private set; }
        // constructor
        public Production ( TypeDeCaisse _caisse, int _nombreDeCaisseAProduire )
        {
            caisse = _caisse;
            nombreDeCaisseAProduire = _nombreDeCaisseAProduire;
            DefautParHeure = 0;
            DefautGlobal = 0;
            CompteurProduction = 0;
            Demarre = false;
            tempsDeProductionParCaisse = (int)(3600d/ (double)caisse * 1000d);
        }
        public Production (TypeDeCaisse _caisse): this ( _caisse,1000)
        {
        }
        public void Demarrer()
        {
            // on verifie s'il n'est pas demarrer, alors Demarre passe à true
            if (Demarre == false)
            {
                CompteurProduction = 0;
                DefautParHeure = 0;
                DefautGlobal = 0;
                Demarre = true;
                Executer();
            }

        }

        public void Arreter()
        {
           if( Demarre == true)
            {
                Demarre = false;
            }
        }

        public void Continuer()
        {
            if (Demarre == false)
            {
                Demarre = true;
            }
        }

        public void Executer()
        {
            if (Demarre)
            {
                while (CompteurProduction < nombreDeCaisseAProduire )
                {
                   if(Demarre)
                   {
                        Thread.Sleep(this.tempsDeProductionParCaisse);
                        ++CompteurProduction;
                   }
                }
            }
        }
    }
    
}
