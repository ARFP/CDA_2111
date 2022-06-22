using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoanUI.LoanControl.Input
{
    public class AnnualInterestRateControl : ILoanInput<int>
    {
        GroupBox groupControls;

        public AnnualInterestRateControl(
            GroupBox _groupControls,
            int defaultValue = 0
        )
        {
            groupControls = _groupControls;

            foreach (Control control in groupControls.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    if (String.Equals(radioButton.Tag, defaultValue.ToString()))
                    {
                        //return (int)radioButton.Tag;
                    }

                }
            }
        }

        public int GetValue()
        {
            foreach (Control control in groupControls.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    if (radioButton.Checked)
                        return (int)radioButton.Tag;
                }
            }

            throw new Exception("Values not found");
        }
    }
}