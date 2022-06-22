using LoanUI.Loan;
using LoanUI.LoanControl.Input;
using LoanUI.MVC;

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
                lbxPeriode,
                periodicityUsed,
                periodicityUsed[0]
            );
            capitalLoanControl = new CapitalLoanControl(tbxCapital);
            annualInterestControl = new AnnualInterestRateControl(gbxInterets);
            repaymentMonthControl = new RepaymentMonthControl(
                ScrBarDuree,
                repaymentPeriodicityControl,
                labelNbMois
            );

            this.lbxPeriode.SelectedIndexChanged += lbxPeriode_SelectedIndexChanged;*/
        }

        private void ScrBarDuree_Scroll(object sender, ScrollEventArgs e)
        {
            /*repaymentMonthControl.UpdateUI();*/
        }

        private void lbxPeriode_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* repaymentMonthControl.UpdateUI();*/
        }
    }
}