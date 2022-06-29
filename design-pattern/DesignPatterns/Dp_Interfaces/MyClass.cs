using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dp_intro.Interfaces;
using Dp_intro.Models;


namespace Dp_Interfaces
{
    public class MyClass
    {
        IBatiment bati;
        
        public MyClass(IBatiment bat)
        {
            bati = bat;
        }

        public void AfficherBatiment(IBatiment batiment)
        {
            if(batiment is BienImmobilier b)
            {
                Console.WriteLine("La superficie est égale à " + b.Loyer());
            } 
            else if(batiment is Batiment c) 
            {
                Console.WriteLine("La superficie est égale à " + c.SuperficieTotale());
            }

        }
    }
}
