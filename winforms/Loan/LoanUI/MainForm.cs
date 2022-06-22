using LoanUI.Loan;
using LoanUI.LoanControl.Input;
using System.Diagnostics;

namespace LoanUI
{
    public partial class MainForm : Form
    {
       /* public readonly Periodicity[] periodicityUsed = new Periodicity[]
        {
            new Periodicity("Mensuelle", 1),
            new Periodicity("Bimestrielle", 2),
            new Periodicity("Trimestrielle", 3),
            new Periodicity("Semestrielle", 6),
            new Periodicity("Annuelle", 12),
            new Periodicity("Xoxo", 24)
        };

        RepaymentPeriodicityControl repaymentPeriodicityControl;
        CapitalLoanControl capitalLoanControl;
        AnnualInterestRateControl annualInterestControl;
        RepaymentMonthControl repaymentMonthControl;*/

        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           /* repaymentPeriodicityControl = new RepaymentPeriodicityControl(
                lbxPeriod,
                periodicityUsed,
                periodicityUsed[0]
            );
            capitalLoanControl = new CapitalLoanControl(tbxCapital);
            annualInterestControl = new AnnualInterestRateControl(gbxInterests);
            repaymentMonthControl = new RepaymentMonthControl(
                ScrBarDuration,
                repaymentPeriodicityControl,
                labelNbMonth
            );

            this.lbxPeriod.SelectedIndexChanged += lbxPeriode_SelectedIndexChanged;*/
        }

        private void ScrBarDuree_Scroll(object sender, ScrollEventArgs e)
        {
            /*repaymentMonthControl.UpdateUI();*/
        }

        private void lbxPeriode_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* repaymentMonthControl.UpdateUI();*/
        }

        private void tbxCapital_TextChanged(object sender, EventArgs e)
        {
            double capital;

            if(!double.TryParse(tbxCapital.Text, out capital))
            {
                return;
            }

            foreach (Control ctrl in gbxInterests.Controls)
            {
                RadioButton rb = (RadioButton)ctrl;

                if(rb.Checked)
                {
                    labelAmountRp.Text = (capital + capital * float.Parse(rb.Tag.ToString())).ToString();
                }
            }
        }
    }
}