using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEventHandler
{
    internal class Toto
    {
        public event PropertyChangedEventHandler NameChanged;

        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnNameChanged();
            }
        }

        public Toto(string name)
        {
            Name = name;
        }

        public void OnNameChanged()
        {
            if(NameChanged != null)
            {
                NameChanged(this, new PropertyChangedEventArgs(nameof(Name)));
            }
            
        }
    }
}
