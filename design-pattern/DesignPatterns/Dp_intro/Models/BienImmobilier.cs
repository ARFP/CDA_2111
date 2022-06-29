using Dp_intro.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dp_intro.Models
{
    abstract public class BienImmobilier : IBatiment, IBienImmobilier
    {
        private readonly int _superficieTotale;
        private readonly int _loyer;

        public BienImmobilier(int superficie, int loyer)
        {
            _superficieTotale = superficie;
            _loyer = loyer;
        }

        public int SuperficieTotale()
        {
            return _superficieTotale;
        }

        public int Loyer()
        {
            return _loyer;
        }
    }
}
