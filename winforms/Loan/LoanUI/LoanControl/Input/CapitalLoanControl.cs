using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoanUI.LoanControl.Input
{
    public class CapitalLoanControl : ILoanInputLong
    {
        private TextBox Control { get; set; }

        public CapitalLoanControl(TextBox _control, long? DefaultValue = null)
        {
            Control = _control;
            Control.Text = DefaultValue.ToString() ?? String.Empty;
        }

        public long GetValue()
        {
            return long.Parse(Control.Text);
        }
    }
}