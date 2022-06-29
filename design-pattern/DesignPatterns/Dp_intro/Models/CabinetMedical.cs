using Dp_intro.Interfaces;
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

        public void Accept(IVisiteur visitor)
        {
            visitor.VisitCabinetMedical(this);
        }

        public bool SecretariatInclus()
        {
            return _secretariatInclus;
        }
    }
}