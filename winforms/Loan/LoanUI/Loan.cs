namespace LoanUI
{
    public class Loan
    {
        public Loan()
        {
        }

        public long CapitalLoan
        {
            get => default;
            set
            {
            }
        }

        public int NumberMonths
        {
            get => default;
            set
            {
            }
        }

        public Periodicity RepaymentPeriodicity
        {
            get => default;
            set
            {
            }
        }

        public int AnnualInterestRate
        {
            get => default;
            set
            {
            }
        }

        public double GetSumPerPeriodicity()
        {
            throw new System.NotImplementedException();
        }

        public void GetNumberRepayment()
        {
            throw new System.NotImplementedException();
        }
    }
}