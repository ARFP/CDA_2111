using System.ComponentModel;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        ListManager manager;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            manager = new ListManager()
            {
                Source = new BindingList<string>() { "France", "Belgique", "Allemagne" },
                Target = new BindingList<string>()
            };
            cbxSource.DataSource = manager.Source;
            lbxTarget.DataSource = manager.Target;
        }

        private void btnAddOne_Click(object sender, EventArgs e)
        {
            try
            {
                manager.MoveOne(cbxSource.SelectedIndex);
                // TODO : refresh items
            }   
            catch(IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            manager.MoveAll();
        }

        private void btnRemoveOne_Click(object sender, EventArgs e)
        {
            try
            {
                manager.ReverseMoveOne(lbxTarget.SelectedIndex);
            }
            catch(IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {

        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {

        }

        private void btnMovedown_Click(object sender, EventArgs e)
        {

        }
    }
}