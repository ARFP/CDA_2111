namespace Defilement
{
    public partial class Form1 : Form
    {
        Defilement red;
        Defilement green;
        Defilement blue;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            red = new(hsbRedValue, numRedValue, lblRed, Color.Red);
            green = new(hsbGreenValue, numGreenValue, lblGreen, Color.Green);
            blue = new(hsbBlueValue, numBlueValue, lblBleu, Color.Blue);

            hsbGreenValue.Scroll += ColorValueChanged;
            numGreenValue.ValueChanged += ColorValueChanged;

            hsbBlueValue.Scroll += ColorValueChanged;
            numBlueValue.ValueChanged += ColorValueChanged;
        }

        private void ColorValueChanged(object sender, EventArgs e)
        { 
            if(sender is ScrollBar scrollBar)
            {
                Defilement toto = (Defilement)scrollBar.Tag;
                toto.ChangeValue(scrollBar.Value);
            }
            else if (sender is NumericUpDown upDown)
            {
                Defilement toto = (Defilement)upDown.Tag;
                toto.ChangeValue(upDown.Value);
            }

            SetFinalColor();
        }

        private void SetFinalColor()
        {
            lblResultColor.BackColor = Color.FromArgb(
                hsbRedValue.Value,
                hsbGreenValue.Value,
                hsbBlueValue.Value
            );
        }
    }
}