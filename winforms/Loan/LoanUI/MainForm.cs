using LoanUI.Models;
using System.ComponentModel;

namespace LoanUI
{
    public partial class MainForm : Form
    {
        private Loan loan;

        public MainForm()
        {
            InitializeComponent(); 
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loan = Loan.GetInstance();
            loan.OnUpdate += LoanUpdated;
        }

        private void tbxCapital_TextChanged(object sender, EventArgs e)
        {
            long capital;
            if(!long.TryParse(tbxCapital.Text, out capital))
            {
                return;
            }
            loan.Capital = capital;
        }

        private void Interest_CheckedChanged(object sender, EventArgs e)
        {
            if(sender is RadioButton rb)
            {
                loan.SetAnnualInterestRate(float.Parse(rb.Tag.ToString()));
            }            
        }

        private void LoanUpdated(object sender, PropertyChangedEventArgs e)
        {
            if(sender is Loan loanSender)
            {
                labelNbRp.Text = loanSender.NumberRepayments.ToString();
                labelRp.Text = loanSender.GetSumPerPeriodicity().ToString();
            }
        }
    }
}