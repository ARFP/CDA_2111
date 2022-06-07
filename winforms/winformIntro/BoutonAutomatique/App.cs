namespace BoutonAutomatique
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                MessageBox.Show("C'est bien un bouton", "Toto");
            }
            else
            {
                MessageBox.Show(
                    "Erreur fatale !", 
                    "erreur", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );            
            }
        }
    }
}