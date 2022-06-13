using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBox
{
    internal class ListManager
    {
        public BindingList<string> Source { get; set; }
        public BindingList<string> Target { get; set; }

        public ListManager() {}

        public void ReverseList()
        {
            BindingList<string> tmp = Source;
            Source = Target;
            Target = tmp;
        }

        public void ReverseMoveOne(int index)
        {
            ReverseList();
            MoveOne(index);
            ReverseList();
        }

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
            while(Source.Count > 0)
            {
                Target.Add(Source[0]);
                Source.RemoveAt(0);
            }

            /*int count = Source.Count;

            for(int i = count-1; i >= 0; i--)
            {
                Target.Add(Source[i]);
                Source.RemoveAt(i);
            }
            Target.Reverse();*/
        }

    }
}
