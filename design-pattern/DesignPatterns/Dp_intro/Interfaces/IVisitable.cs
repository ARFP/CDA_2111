using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dp_intro.Interfaces 
{
    public interface IVisitable 
    {
        void Accept(IVisiteur visitor);
    }
}
