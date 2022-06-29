using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMdiContainer.Lib
{
    internal interface IFormBuilder
    {
        Form CreateInstance();
    }
}
