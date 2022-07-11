using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoMdiContainer.Apps;
using DemoMdiContainer.Lib;

namespace DemoMdiContainer
{
    public partial class FrmDemo : Form
    {
        public TextBox TextValid { get; private set; }

        public FrmDemo()
        {
            InitializeComponent();
        }

        private void FrmDemo_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show("TOTO");
        }

        private void btnValid_Click(object sender, EventArgs e)
        {
            NameValidate validator = new NameValidate();

            if(!validator.IsValid(textValid.Text))
            {
                MessageBox.Show("Le nom est vide !");
                return;
            } 

            FrmValidationSaisie form = new FrmValidationSaisie();
            form.MdiParent = this.MdiParent;
            form.SetFormDemo(this);
            form.Show();
            this.Close();
        }
    }
}
