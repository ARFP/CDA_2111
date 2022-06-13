using System.Diagnostics;
using System.Text;

namespace MyStringBuilder
{
    public partial class Form1 : Form
    {
        Stopwatch stopwatch;
        string myText;
        StringBuilder builder;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stopwatch = new Stopwatch();
           // builder = new StringBuilder();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
            //builder.Clear();
            for(int i= 0; i < 100000; i++)
            {
                myText += "a";
               // builder.Append("a");
            }
            txtView.Text = myText;
           // txtView.Text = builder.ToString();
            stopwatch.Stop();

            txtResult.Text = (stopwatch.ElapsedMilliseconds/1000.0).ToString("##.####");
        }
    }
}