using LoanUI.Loan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoanUI.LoanControl.Input
{
    public class RepaymentMonthControl : ILoanInputInt
    {
        public const int MAX = 360;
        private ScrollBar control;
        private ILoanInputPeriodicity repaymentPeriodicityControl;
        private Label resultControl;

        public RepaymentMonthControl(
            ScrollBar _control,
            RepaymentPeriodicityControl _repaymentPeriodicityControl,
            Label _resultControl
        )
        {
            control = _control;
            repaymentPeriodicityControl = _repaymentPeriodicityControl;
            resultControl = _resultControl;
        }

        public int GetValue()
        {
            return control.Value;
        }

        public void UpdateUI()
        {
            Periodicity periodSelected = repaymentPeriodicityControl.GetValue();

            control.Minimum = periodSelected.HowManyMonths;
            control.SmallChange = periodSelected.HowManyMonths;
            control.LargeChange = periodSelected.HowManyMonths * 2;
            control.Maximum = MAX + control.LargeChange - control.SmallChange;

            if ((double)control.Value % (double)periodSelected.HowManyMonths != 0.0)
            {
                control.Value =
                    control.Value
                    / periodSelected.HowManyMonths
                    * periodSelected.HowManyMonths
                    + periodSelected.HowManyMonths;
            }

            resultControl.Text = GetValue().ToString();
        }
    }
}