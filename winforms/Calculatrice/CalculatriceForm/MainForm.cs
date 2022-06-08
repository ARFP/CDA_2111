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
                TbResult.Text = TbResult.Text + "+" + button.Text;
            }
        }

        private void BResult_Click(object sender, EventArgs e)
        {
            TbResult.Text += " = " + anOperator.GetResult().ToString();
        }

        private void BClear_Click(object sender, EventArgs e)
        {
            anOperator = new Operator();
            TbResult.Text = String.Empty;
        }
    }
}