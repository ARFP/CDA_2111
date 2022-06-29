using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dp_intro.Models
{
    public class Bureau : BienImmobilier
    {

        private readonly List<string> _equipements;

        public Bureau(int superficie, int loyer, List<string> equipements) : base(superficie, loyer)
        {
            _equipements = equipements;
        }

        public List<string> ListeEquipements()
        {
            return _equipements;
        }
    }
}
