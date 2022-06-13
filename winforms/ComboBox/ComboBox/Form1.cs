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
                Source = new List<string>() { "France", "Belgique" },
                Target = new List<string>()
            };
            cbxSource.DataSource = manager.Source;
            lbxTarget.DataSource = manager.Target;
        }


        /*private void MoveItem(ListControl source, ListControl target)
        {
            if(source.SelectedIndex > -1)
            {
                var item = source.Items[source.SelectedIndex];
            }
        }*/

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

        private void btnRemoveOne_Click(object sender, EventArgs e)
        {
            if(lbxTarget.SelectedIndex > -1)
            {
                var item = lbxTarget.SelectedItem;
                cbxSource.Items.Add(item);
                lbxTarget.Items.RemoveAt(lbxTarget.SelectedIndex);
            }
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {

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