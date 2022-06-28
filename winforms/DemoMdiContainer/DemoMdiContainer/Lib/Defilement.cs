using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMdiContainer.Lib
{ 
    internal class Defilement
    {
        HScrollBar scrollBar;
        NumericUpDown upDown;
        Color color;
        Label label;

        public Defilement(HScrollBar _scrollBar,NumericUpDown _upDown,Label _label,Color _color)
        {
            scrollBar = _scrollBar;
            upDown = _upDown;
            label = _label;
            color = _color;
            scrollBar.Tag = this;
            upDown.Tag = this;
        }

        public void ChangeValue(int _value)
        {
            scrollBar.Value = _value;
            upDown.Value = _value;
            label.BackColor = Color.FromArgb(_value, color);
        }

        public void ChangeValue(decimal _value)
        {
            ChangeValue((int)_value);
        }
    }
}
