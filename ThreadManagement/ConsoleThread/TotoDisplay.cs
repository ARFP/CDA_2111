using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleThread
{
    public interface IToto
    {
        void Display(int result);
    }

    public class TotoDisplay : IToto
    {
        public void Display(int result)
        {
            Console.WriteLine("TotoDisplay = " + result);
        }
    }

    public class TataDisplay : IToto
    {
        public void Display(int result)
        {
            Console.WriteLine(result + " by TataDisplay");
        }
    }
}
