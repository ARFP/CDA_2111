using CalculatriceCore;

namespace CalculatriceForm
{
    public partial class MainForm : Form
    {
        Operator anOperator;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            anOperator = new Operator();
        }

        private void NumberToAdd_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                anOperator.AdditionNumber(Int32.Parse(button.Text));
                DisplayAddition(button.Text);
            }
        }

        private void BResult_Click(object sender, EventArgs e)
        {
            DisplayResult();
        }

        private void BClear_Click(object sender, EventArgs e)
        {
            anOperator = new Operator();
            ClearDisplay();
        }

        #region Display

        private void DisplayAddition(string number)
        {
            TbResult.Text = TbResult.Text + "+" + number;
        }

        private void DisplayResult()
        {
            TbResult.Text += " = " + anOperator.GetResult().ToString();
        }

        private void ClearDisplay()
        {
            TbResult.Text = String.Empty;
        }

        #endregion Display
    }
}