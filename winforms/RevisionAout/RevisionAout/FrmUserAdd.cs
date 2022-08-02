using RevisionAout.Dao;
using RevisionAout.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevisionAout
{
    public partial class FrmUserAdd : Form
    {
        UserWorkUnit uwu;

        public FrmUserAdd()
        {
            InitializeComponent();
            uwu = new UserWorkUnit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserAddViewModel newUser = new UserAddViewModel()
            {
                UserName = textBox1.Text,
                Password = textBox2.Text,
            };

            try
            {
                uwu.Adduser(newUser);
            }
            catch(Exception ex)
            {

            }
            
        }
    }
}
