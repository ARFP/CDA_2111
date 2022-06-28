using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMdiContainer.Lib
{
    internal class FormBuilder<T> where T:Form,new()
    {
        private Form parentForm;
        private int index;

        public FormBuilder(Form parentForm)
        {
            index = 0;
            this.parentForm = parentForm;
        }

        public T CreateInstance()
        {
            T f = new T();
            f.Text += " N°" + ++index;
            f.MdiParent = parentForm;
            f.MaximizeBox = false;
            f.MinimizeBox = false;
            f.WindowState = FormWindowState.Maximized;
            return f;
        }
    }
}
