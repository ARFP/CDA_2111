using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanUI.LoanControl
{
    public interface ILoanInput<T>
    {
        T GetValue();
    }
}
