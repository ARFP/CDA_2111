using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dp_intro.Models
{
    public class CabinetMedical : BienImmobilier
    {
        private readonly bool _secretariatInclus;

        public CabinetMedical(int superficie, int loyer, bool avecSecretariat) : base(superficie, loyer)
        {
            _secretariatInclus = avecSecretariat;
        }

        public bool SecretariatInclus()
        {
            return _secretariatInclus;
        }
    }
}