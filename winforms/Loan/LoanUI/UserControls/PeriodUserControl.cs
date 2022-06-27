using LoanUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanUI.UserControls
{
    public partial class PeriodUserControl : UserControl
    {
        public Loan Loan { get; set; }

        public int NbMonths 
        { 
            get 
            {
                return sbNbMonths.Value;
            }  
        }

        public int Period 
        {
            get
            {
                return periodicityUsed[lbPeriodicity.SelectedIndex].HowManyMonths;
            }
        }

        public readonly Periodicity[] periodicityUsed = new Periodicity[]
        {
            new Periodicity("Mensuelle", 1),
            new Periodicity("Bimestrielle", 2),
            new Periodicity("Trimestrielle", 3),
            new Periodicity("Semestrielle", 6),
            new Periodicity("Annuelle", 12),
            new Periodicity("Xoxo", 24)
        };

        public PeriodUserControl()
        {
            InitializeComponent();
        }

        private void PeriodUserControl_Load(object sender, EventArgs e)
        {
            Loan = Loan.GetInstance();
            lbPeriodicity.DataSource = periodicityUsed;
        }

        private void lbPeriodicity_SelectedIndexChanged(object sender, EventArgs e)
        {
            sbNbMonths.Minimum = Period;
            sbNbMonths.SmallChange = Period;
            sbNbMonths.LargeChange = Period * 2;
            sbNbMonths.Maximum = 360 + (sbNbMonths.LargeChange - 1);
            sbNbMonths.Value = sbNbMonths.Minimum;
            Loan.Periodicity = Period;
            sbNbMonths_ValueChanged(sbNbMonths, new EventArgs());
        }

        private void sbNbMonths_ValueChanged(object sender, EventArgs e)
        {
            labelNbMonths.Text = sbNbMonths.Value.ToString();
            Loan.SetNumberMonths(NbMonths);
        }
    }
}
