using System.ComponentModel;

namespace LoanUI.Models
{
    public class Loan
    {
        #region
        /// <summary>
        /// Permet une seule instance de la classe Loan (singleton pattern)
        /// 
        /// </summary>
        private static Loan? instance = null;

        public static Loan GetInstance()
        {
            if(instance == null)
            {
                instance = new Loan();
            }
            return instance;
        }
        #endregion
        public event PropertyChangedEventHandler OnUpdate;

        private Loan() 
        {
            Capital = 0;
            Periodicity = 1;
            AnnualInterestRate = 0.07F;
            NumberMonths = 1;
        }

        private long _capitalLoan;

        public long Capital
        {
            get => _capitalLoan;
            set
            {
                if(value > 0 && value < 10000000000)
                {
                    _capitalLoan = value;
                    Updated();
                }
            }
        }

        public int NumberMonths
        {
            get; private set;
        }

        private int _periodicity;
        
        /// <summary>
        /// La périodicité en mois
        /// </summary>
        public int Periodicity
        {
            get => _periodicity;
            set
            {
                if(value > 0)
                {
                    _periodicity = value;
                    Updated();
                }
            }
        }

        public float AnnualInterestRate
        {
            get; private set;
        }

        public int NumberRepayments { get { return (NumberMonths / Periodicity); } }

        public double MonthlyInterest 
        {  
            get { return (AnnualInterestRate / (12 / Periodicity)); 
            } 
        }

        public void SetAnnualInterestRate(float newValue)
        {
            if(newValue > 0 && newValue < 1)
            {
                AnnualInterestRate = newValue;
                Updated();
            }
        }

        public void SetNumberMonths(int newValue)
        {
            if (newValue > 0 && newValue <= 360)
            {
                NumberMonths = newValue;
                Updated();
            }
        }


        public double GetSumPerPeriodicity()
        {
            // capital * T / (1-(1+T)pow(NbRepayment)

            return Capital * MonthlyInterest / (1 - Math.Pow(1 + MonthlyInterest, -NumberRepayments));
        }

        private void Updated()
        {
            if(OnUpdate != null)
            {
                OnUpdate(this, new PropertyChangedEventArgs(nameof(AnnualInterestRate)));
            }
        }
    }
}