using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleThread
{
    public interface IWriter
    {
        void WriteResult(int result);
    }

    public class ResultTextWriter : IWriter
    {
        public void WriteResult(int result)
        {
            Console.WriteLine("ResultTextWriter = " + result);
        }
    }

    public class ResultAlternateTextWriter : IWriter
    {
        public void WriteResult(int result)
        {
            Console.WriteLine(result + " from ResultAlternateTextWriter");
        }
    }
}
