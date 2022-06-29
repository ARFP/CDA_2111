using Dp_intro.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dp_intro.Models
{
    public class Batiment : IBatiment
    {
        private int superficie;

        public Batiment(int superficie)
        {
            this.superficie = superficie;
        }

        public int SuperficieTotale()
        {
            return superficie;
        }
    }
}
