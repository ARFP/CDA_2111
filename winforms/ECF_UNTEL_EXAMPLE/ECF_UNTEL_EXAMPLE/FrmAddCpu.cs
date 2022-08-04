using ECF_UNTEL_EXAMPLE.Domain;
using ECF_UNTEL_EXAMPLE.Domain.Models;
using ECF_UNTEL_EXAMPLE.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECF_UNTEL_EXAMPLE
{
    public partial class FrmAddCpu : Form
    {
        CpuAddViewModel model;
        FrmHome home;

        public FrmAddCpu()
        {
            InitializeComponent();
        }

        public FrmAddCpu(FrmHome _home) : this()
        {
            home = _home;
        }

        private void FrmAddCpu_Load(object sender, EventArgs e)
        {
            numericUpDownFrequency.DecimalPlaces = 3;
            numericUpDownFrequency.Value = 3.200M;

            numericUpDownPrice.DecimalPlaces = 2;
            numericUpDownPrice.Value = 99.99M;

            cbxFamily.DataSource = DomainData.Families;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            model = new CpuAddViewModel(new Cpu()
            {
                Reference = txtRef.Text,
                Name = txtName.Text,
                Frequency = (double)numericUpDownFrequency.Value,
                Price = (double)numericUpDownPrice.Value,
                Family = (Family)cbxFamily.SelectedItem,
                ReleaseDate = dateTimeRelease.Value
            });

            if(!model.IsValid())
            {
                MessageBox.Show(model.Errors);
            }
            else
            {
                DomainData.Cpus.Add(model.Cpu);
                home.UpdateData();
                this.Close();
            }
        }
    }
}
