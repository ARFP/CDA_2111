using DemoMdiContainer.Apps;
using DemoMdiContainer.Lib;

namespace DemoMdiContainer
{
    public partial class FrmMenu : Form
    {

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            menuDemo.Tag = new FormBuilder<FrmDemo>(this);
            menuDefil.Tag = new FormBuilder<FrmDefilement>(this);
        }

        private void menuSignIn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Bienvenue");
            menuStep1.Enabled = true;
            menuStep2.Enabled = true;
            menuStep3.Enabled = true;
            menuWindows.Enabled = true;
        }

        private void menuQuit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Quitter l'application ?", 
                "Quitter ?", 
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void menuAppClick(object sender, EventArgs e)
        {
            ToolStripMenuItem myMenu = (ToolStripMenuItem) sender;

            IFormBuilder myFormBuilder = (IFormBuilder)myMenu.Tag;

            Form form = myFormBuilder.CreateInstance();

            form.FormClosing += this.App_Closing;

            labelLastWindow.Text = form.Text;

            form.Show();

            // myFormBuilder.CreateInstance().Show();
        }       

        public void App_Closing(object? sender, FormClosingEventArgs e)
        {
            if(sender is Form form)
            {
                labelLastWindow.Text = form.Text + " fermé";
            }
        }

        
    }
}