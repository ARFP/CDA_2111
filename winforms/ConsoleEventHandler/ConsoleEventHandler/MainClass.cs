using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEventHandler
{
    internal class MainClass
    {
        public MainClass(Toto toto)
        {
            toto.NameChanged += ListenToto;
        }

        public void ListenToto(object sender, PropertyChangedEventArgs e)
        {
            Toto toto = (Toto)sender;

            Console.WriteLine("Le nom a changé. Nouveau nom : " + toto.Name);
        }
    }
}
