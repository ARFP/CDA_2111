using LoanUI.Loan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoanUI.LoanControl.Input
{
    public class RepaymentPeriodicityControl : ILoanInputPeriodicity
    {
        private ListBox Control { get; set; }
        private Periodicity[] periodicityUsed;

        public RepaymentPeriodicityControl(
            ListBox _control,
            Periodicity[] _periodicityUsed,
            Periodicity DefaultValue
        )
        {
            Control = _control;
            periodicityUsed = _periodicityUsed;

            /*foreach (Periodicity period in periodicityUsed)
            {
                Control.Items.Add(period.ToString());
            }*/

            for (int indexPeriod = 0; indexPeriod < periodicityUsed.Length; indexPeriod++)
            {
                Control.Items.Add(periodicityUsed[indexPeriod].ToString());
                if (periodicityUsed[indexPeriod] == DefaultValue)
                {
                    Control.SelectedIndex = indexPeriod;
                }
            }
        }

        public Periodicity GetValue()
        {
            foreach (Periodicity period in periodicityUsed)
            {
                if ((string)Control.SelectedItem == period.ToString())
                    return period;
            }

            throw new Exception("Periodicity not found");
        }
    }
}