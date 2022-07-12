using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleThread
{
    public  class SquareCalculator
    {
        private int number;

        public SquareCalculator(int _number)
        {
            number = _number;
        }

        public void SquareIt()
        {
            number *= number;
        }
    }
}
