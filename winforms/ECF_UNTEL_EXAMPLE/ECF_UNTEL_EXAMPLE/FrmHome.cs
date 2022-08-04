using ECF_UNTEL_EXAMPLE.Domain;
using ECF_UNTEL_EXAMPLE.Domain.Models;
using ECF_UNTEL_EXAMPLE.Domain.ViewModels;
using System.Text.Json;

namespace ECF_UNTEL_EXAMPLE
{
    public partial class FrmHome : Form
    {
        FrmAddCpu frmAddCpu;

        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        public void UpdateData()
        {
            dataGridView1.DataSource = null;

            DomainData.Load();

            dataGridView1.DataSource = DomainData.CpuList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddCpu = new FrmAddCpu(this);
            frmAddCpu.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                path = Path.Combine(path, "cpu-untel.json");

                string json = JsonSerializer.Serialize(DomainData.Cpus);
                File.WriteAllText(path, json);
                MessageBox.Show("Sauvegarde réussie !");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

    }
}