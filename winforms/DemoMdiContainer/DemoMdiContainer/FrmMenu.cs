using DemoMdiContainer.Apps;

namespace DemoMdiContainer
{
    public partial class FrmMenu : Form
    {
        List<Form> launchedApps;

        public FrmMenu()
        {
            InitializeComponent();
            launchedApps = new List<Form>();
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

        private void menuDemo_Click(object sender, EventArgs e)
        {
            List<Form> result = launchedApps.FindAll(f => f is FrmDemo);

            int id = result.Count + 1;

            Form demo = new FrmDemo();
            demo.Text += " N°" + id;
            demo.MdiParent = this;
            demo.MaximizeBox = false;
            demo.MinimizeBox = false;
            demo.WindowState = FormWindowState.Maximized;
            launchedApps.Add(demo);
            demo.FormClosing += App_Closing;
            demo.Show();
        }

        private void menuDefil_Click(object sender, EventArgs e)
        {
            List<Form> result = launchedApps.FindAll(f => f is FrmDefilement);

            int id = result.Count + 1;

            Form defil = new FrmDefilement();
            defil.Text += " N°" + id;
            defil.MdiParent = this;
            defil.MaximizeBox = false;
            defil.MinimizeBox = false;
            defil.WindowState = FormWindowState.Maximized;
            launchedApps.Add(defil);
            defil.FormClosing += App_Closing;
            defil.Show();
        }

        public void App_Closing(object sender, FormClosingEventArgs e)
        {
            if(sender is Form form)
            {
                // MessageBox.Show(form.GetHashCode().ToString());
                launchedApps.Remove(form);
            }
        }
    }
}