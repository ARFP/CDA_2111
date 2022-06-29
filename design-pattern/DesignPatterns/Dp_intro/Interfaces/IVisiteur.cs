using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dp_intro.Models;

namespace Dp_intro.Interfaces
{
    public interface IVisiteur
    {
        void VisitBureau(Bureau batiment);

        void VisitCabinetMedical(CabinetMedical batiment);

        void VisitLocalCommercial(LocalCommercial batiment);
    }
}
