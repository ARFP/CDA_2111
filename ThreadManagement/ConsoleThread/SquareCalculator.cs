using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleThread
{
    public delegate void DisplayNumber(int num);

    public  class SquareCalculator
    {
        private int number;

        private DisplayNumber? callback;

        public SquareCalculator(int _number, DisplayNumber? _callback)
        {
            number = _number;
            callback = _callback;
        }

        public void SquareIt()
        {
            number *= number;

            if(callback != null)
            {
                callback.Invoke(number);
            }
        }
    }
}
