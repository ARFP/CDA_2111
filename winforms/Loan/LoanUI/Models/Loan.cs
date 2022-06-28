using System.ComponentModel;

namespace LoanUI.Models
{
    public class Loan
    {
        #region
        /// <summary>
        /// Permet une seule instance de la classe Loan (singleton pattern)
        /// Un champ privé statique qui contient l'instance unique
        /// + une méthode publique qui crée l'instance si 'elle n'existe pas et la retourne
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

        /// <summary>
        /// Permet aux autres composants de s'abonner à l'évènement OnUpdate
        /// CF la méthode Updated() pour voir le déclenchement de l'évènement
        /// </summary>
        public event PropertyChangedEventHandler OnUpdate;

        /// <summary>
        /// Construction de l'objet avec les valeurs par défaut
        /// </summary>
        private Loan() 
        {
            Capital = 0;
            Periodicity = 1;
            AnnualInterestRate = 0.07F;
            NumberMonths = 1;
        }

        private long _capitalLoan;

        /// <summary>
        /// Capital initial
        /// </summary>
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

        /// <summary>
        /// Nombre de mois pour l'emprunt en cours
        /// </summary>
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
                    Updated(); // déclenchement de l'évènement
                }
            }
        }

        /// <summary>
        /// Intérêts annuels
        /// </summary>
        public float AnnualInterestRate
        {
            get; private set;
        }

        /// <summary>
        /// Retourne le nombre de remboursements selon la nombre de mois et la périodicité courante
        /// </summary>
        public int NumberRepayments { get { return (NumberMonths / Periodicity); } }

        /// <summary>
        /// Intérêts mensuels
        /// </summary>
        public double MonthlyInterest 
        {  
            get { return (AnnualInterestRate / (12 / Periodicity)); 
            } 
        }

        /// <summary>
        /// Définit le taux d'intérêt annuel
        /// 
        /// </summary>
        /// <param name="newValue">le nouveau taux d'intérêt dans sa forme décimale (ex: 8% --> 0.08)</param>
        public void SetAnnualInterestRate(float newValue)
        {
            if(newValue > 0 && newValue < 1)
            {
                AnnualInterestRate = newValue;
                Updated();
            }
        }

        /// <summary>
        /// Définit le nombre de mois pour l'emprunt courant
        /// </summary>
        /// <param name="newValue"></param>
        public void SetNumberMonths(int newValue)
        {
            if (newValue > 0 && newValue <= 360)
            {
                NumberMonths = newValue;
                Updated();
            }
        }

        /// <summary>
        /// Calcule et retourne le montant d'une "mensualité"
        /// </summary>
        /// <returns></returns>
        public double GetSumPerPeriodicity()
        {
            // capital * T / (1-(1+T)pow(NbRepayment)

            return Capital * MonthlyInterest / (1 - Math.Pow(1 + MonthlyInterest, -NumberRepayments));
        }

        /// <summary>
        /// Cette méthode est appelée lorsque certaines propriétés sont mises à jour 
        /// </summary>
        private void Updated()
        {
            // si au moins 1 abonné à l'évènement
            if(OnUpdate != null)
            {
                // invocation de l'évènement. Tous les abonnés sont notifiés !
                OnUpdate(this, new PropertyChangedEventArgs(nameof(AnnualInterestRate)));
            }
        }
    }
}