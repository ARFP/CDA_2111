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

        private void ReverseList()
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

        public void ReverseMoveAll()
        {
            ReverseList();
            MoveAll();
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

        /*public void MoveItemUp(int index)
        {
            if (index >= 0 && index < Target.Count - 1)
            {
                string tmp = Target[index];

            }
        }

        public void MoveItemDown(int index)
        {
            
        }*/
        /// <summary>
        /// Déplacer un élément d'une liste d'un certain nombre d'index (offset)
        /// </summary>
        /// <param name="index">Index de l'élement à déplacer</param>
        /// <param name="offset">Nombre d'index à déplacer</param>
        /// <returns>Retourne l'index du nouvel emplacement ou l'index actuel si aucun déplacement n'a été effectué</returns>
        public int MoveItem(int index, int offset)
        {
            int newIndex = index + offset;

            if (offset != 0
                && index >= 0
                && index <= Target.Count - 1
                && newIndex <= Target.Count
                && newIndex >= 0)
            {
                int oldIndex = offset > 0 ? index : index + 1;
                
                string tmp = Target[index];
                Target.Insert(newIndex, tmp);
                Target.RemoveAt(oldIndex);

                return offset > 0 ? newIndex - 1 : newIndex;
            }

            return index;
        }
    }
}
