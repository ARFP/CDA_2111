using System.Media;
using System.Net;

namespace ThreadManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongTimeString();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(AddText);
            //Thread thread2 = new Thread(AddText2);
            thread.Start();
           // thread2.Start("Salut");
        }

        private void AddText()
        {
            Thread.Sleep(5000);

            //txtResult.Text += "Yeah ";

            this.Invoke(new MethodInvoker(() => {
                txtResult.Text += "Yeah ";
            }));

            Thread.Sleep(5000);
        }

        private void AddText2(object txt)
        {
            Thread.Sleep(3000);

            SoundPlayer player = new SoundPlayer(@"C:\Users\Formateur\a.wav");
            player.Play();

            this.Invoke(new MethodInvoker(() => {
                txtResult.Text += (string)txt + " ";
            }));

            Thread.Sleep(3000);
        }

    }
}