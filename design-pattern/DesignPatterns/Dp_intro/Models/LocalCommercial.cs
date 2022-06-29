using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dp_intro.Models
{
    public class LocalCommercial : BienImmobilier
    {
        private readonly int _maxClients;

        public LocalCommercial(int superficie, int loyer) : base(superficie, loyer)
        {
            _maxClients = superficie / 4;
        }

        public int MaxClients()
        {
            return _maxClients;
        }
    }
}
