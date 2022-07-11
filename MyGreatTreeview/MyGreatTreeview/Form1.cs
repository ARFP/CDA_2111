namespace MyGreatTreeview
{
    public partial class Form1 : Form
    {
        MyTreeNode myNode;
        public Form1()
        {
            InitializeComponent();
            myNode = new MyTreeNode();
        }

        /**
         * Lire le chemin du txtPath
         * Si le chemin existe, parcours du dossier récursivement
         * et alimente treeview1
        **/
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if(DialogResult.OK == fbd.ShowDialog())
                {
                    txtPath.Text = fbd.SelectedPath.Trim(new char[] { '\\', '/' });
                    TreeNode tree = myNode.ScanDir(txtPath.Text);
                    treeView1.Nodes.Clear();
                    treeView1.Nodes.Add(txtPath.Text);
                    treeView1.Nodes.Add(tree);
                }

                
            }
            catch(DirectoryNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
                treeView1.Nodes.Clear();
            }
            
        }

        private void btnExpandOrCollapse_Click(object sender, EventArgs e)
        {

        }
    }
}