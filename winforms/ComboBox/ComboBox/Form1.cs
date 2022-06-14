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

            btnMovedown.Tag = 2;
            btnMoveUp.Tag = -1;
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
            manager.ReverseMoveAll();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            if (sender is Control control)
            {
                lbxTarget.SelectedIndex =
                    manager.MoveItem(
                        lbxTarget.SelectedIndex,
                        (int)control.Tag
                );
            }
        }
    }
}