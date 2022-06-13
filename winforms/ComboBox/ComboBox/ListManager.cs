using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBox
{
    internal class ListManager
    {
        public List<string> Source { get; set; }
        public List<string> Target { get; set; }

        public ListManager() {}

        public void MoveOne(int index)
        {
            if(index < 0 || index >= Source.Count)
            {
                throw new IndexOutOfRangeException("Hors limite boubours !");
            }

            Target.Add(Source[index]);
            Source.RemoveAt(index);
        }

        public void MoveAll()
        {

        }

    }
}
