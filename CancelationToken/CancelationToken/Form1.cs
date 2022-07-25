namespace CancelationToken
{
    public partial class Form1 : Form
    {
        private MyDutyTask myTask;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myTask = new MyDutyTask();

            timer1.Interval = 500;
            timer1.Start();
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            myTask.Stop();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            myTask.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lCounter.Text = myTask.counterToShow.ToString();
        }
    }
}